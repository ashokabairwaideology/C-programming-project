<?php
// $Id$

/******************************************************************************/
/***************************** MANAGE FEEDBACK ********************************/
/******************************************************************************/

function manage_feedback_form($form_state)
{
	global $user;

	$feedback_id = (int)arg(3);
	$feedback_q = db_query("SELECT * FROM assignment_feedback_submissions WHERE id = %d LIMIT 1", $feedback_id);
	$feedback_data = db_fetch_object($feedback_q);
	if (!$feedback_data) {
		drupal_set_message(t('Invalid Feedback'), 'error');
		drupal_goto('feedback/manage');
		return;
	}
	$user_data = user_load($feedback_data->uid);
	$node_data = node_load($feedback_data->nid);

  $form['name'] = array(
    '#type' => 'item',
    '#title' => t('Your username'),
    '#value' => $user_data->name,
  );

  $form['tutorial_name'] = array(
    '#type' => 'item',
    '#title' => t('Name of the Tutorial'),
    '#value' => $node_data->title,
  );

  $form['feedback_type'] = array(
    '#type' => 'item',
    '#title' => t('Feedback Type'),
    '#value' => _feedback_type($feedback_data->feedback_type),
  );

  $form['feedback_where'] = array(
    '#type' => 'item',
    '#title' => t('Where'),
    '#value' => _feedback_where($feedback_data->feedback_where),
  );

  $form['timing'] = array(
    '#type' => 'item',
    '#title' => t('Start Time'),
    '#value' => $feedback_data->timing,
  );

  $form['completion_time'] = array(
    '#type' => 'item',
    '#title' => t('How long did you take to complete the assignment'),
    '#value' => $feedback_data->completion_time . ' minutes',
  );

  $form['comments'] = array(
    '#type' => 'textarea',
    '#title' => t('Comment Box'),
    '#value' => $feedback_data->comments,
    '#disabled' => TRUE,
  );

  /* file attachments */
  $attachment_q = db_query("SELECT * FROM {assignment_feedback_attachments} WHERE submission_id = %d", $feedback_id);
  if ($attach1_data = db_fetch_object($attachment_q)) {
		$form['attach1'] = array(
			'#type' => 'item',
			'#title' => t('Attachment 1'),
			'#value' => l($attach1_data->filename, $attach1_data->filepath),
		);
		if ($attach2_data = db_fetch_object($attachment_q)) {
			$form['attach2'] = array(
				'#type' => 'item',
				'#title' => t('Attachment 2'),
				'#value' => l($attach2_data->filename, $attach2_data->filepath),
			);
			if ($attach3_data = db_fetch_object($attachment_q)) {
				$form['attach3'] = array(
					'#type' => 'item',
					'#title' => t('Attachment 2'),
					'#value' => l($attach3_data->filename, $attach3_data->filepath),
				);
			}
		}
	}

  $form['status'] = array(
    '#type' => 'radios',
    '#title' => t('Approval Status'),
    '#options' => array(1 => 'Approve', 2 => 'Disapprove'),
    '#required' => TRUE,
  );

  $form['message'] = array(
    '#type' => 'textarea',
    '#title' => t('Reason for disapproval'),
  );

  $form['feedback_id'] = array(
    '#type' => 'hidden',
    '#value' => $feedback_id,
  );

  $form['submit'] = array(
    '#type' => 'submit',
    '#value' => t('Submit')
  );

  $form['cancel'] = array(
    '#type' => 'markup',
    '#value' => l(t('Cancel'), 'feedback/manage'),
  );

  return $form;
}

function manage_feedback_form_submit($form, &$form_state)
{
	global $user;

	$feedback_id = (int)arg(3);
	$feedback_q = db_query("SELECT * FROM assignment_feedback_submissions WHERE id = %d LIMIT 1", $feedback_id);
	$feedback_data = db_fetch_object($feedback_q);
	if (!$feedback_data) {
		drupal_set_message(t('Invalid Feedback'), 'error');
		drupal_goto('feedback/manage');
		return;
	}
	$user_data = user_load($feedback_data->uid);
	$node_data = node_load($feedback_data->nid);

	/* updating feedback */
	if ($form_state['values']['status'] == 1) {
		/* feedback approve */
		db_query("UPDATE {assignment_feedback_submissions} SET status = %d, approver_uid = %d, approver_timestamp = %d WHERE id = %d", 1, $user->uid, time(), $feedback_id);

		/* sending email */
		$email_to = $user_data->mail;
		$param['feedback_approved']['user_id'] = $user_data->uid;
		$param['feedback_approved']['tutorial_name'] = $node_data->title;
		$param['feedback_approved']['feedback_type'] = _feedback_type($feedback_data->feedback_type); 
		$param['feedback_approved']['feedback_where'] = _feedback_where($feedback_data->feedback_where);
		$param['feedback_approved']['timing'] = $feedback_data->timing;
		$param['feedback_approved']['completion_time'] = $feedback_data->completion_time;
		$param['feedback_approved']['comments'] = $feedback_data->comments;
		if (!drupal_mail('assignment_feedback', 'feedback_approved', $email_to, language_default(), $param, variable_get('textbook_companion_from_email', NULL), TRUE))
			drupal_set_message('Error sending email message.', 'error');
		$email_to = variable_get('assignment_feedback_emails', NULL);
		if (!drupal_mail('assignment_feedback', 'feedback_approved', $email_to, language_default(), $param, variable_get('textbook_companion_from_email', NULL), TRUE))
			drupal_set_message('Error sending email message.', 'error');
	
		drupal_set_message(t('Feedback No. ' . $feedback_id . ' has been approved and a notification email has been sent to the user.'), 'status');
	} else if ($form_state['values']['status'] == 2) {
		/* feedback disapprove */
		db_query("UPDATE {assignment_feedback_submissions} SET status = %d, approver_uid = %d, approver_timestamp = %d, disapprove_message = '%s' WHERE id = %d", 2, $user->uid, time(), $form_state['values']['message'], $feedback_id);

		/* sending email */
		$email_to = $user_data->mail;
		$param['feedback_disapproved']['user_id'] = $user_data->uid;
		$param['feedback_disapproved']['tutorial_name'] = $node_data->title;
		$param['feedback_disapproved']['feedback_type'] = _feedback_type($feedback_data->feedback_type); 
		$param['feedback_disapproved']['feedback_where'] = _feedback_where($feedback_data->feedback_where);
		$param['feedback_disapproved']['timing'] = $feedback_data->timing;
		$param['feedback_disapproved']['completion_time'] = $feedback_data->completion_time;
		$param['feedback_disapproved']['comments'] = $feedback_data->comments;
		$param['feedback_disapproved']['reason'] = $form_state['values']['message'];

		if (!drupal_mail('assignment_feedback', 'feedback_disapproved', $email_to, language_default(), $param, variable_get('textbook_companion_from_email', NULL), TRUE))
			drupal_set_message('Error sending email message.', 'error');
		$email_to = variable_get('assignment_feedback_emails', NULL);
		if (!drupal_mail('assignment_feedback', 'feedback_disapproved', $email_to, language_default(), $param, variable_get('textbook_companion_from_email', NULL), TRUE))
			drupal_set_message('Error sending email message.', 'error');

		drupal_set_message(t('Feedback No. ' . $feedback_id . ' has been disapproved and a notification email has been sent to the user.'), 'status');
	}

	drupal_goto('feedback/manage');
}

/******************************************************************************/
/******************************* EDIT FEEDBACK ********************************/
/******************************************************************************/

function edit_feedback_form($form_state)
{
	global $user;

	$feedback_id = (int)arg(3);
	$feedback_q = db_query("SELECT * FROM assignment_feedback_submissions WHERE id = %d LIMIT 1", $feedback_id);
	$feedback_data = db_fetch_object($feedback_q);
	if (!$feedback_data) {
		drupal_set_message(t('Invalid Feedback'), 'error');
		drupal_goto('feedback/manage');
		return;
	}
	$user_data = user_load($feedback_data->uid);
	$node_data = node_load($feedback_data->nid);

  /* add javascript for automatic book title, check if example uploaded, dependency selection effects */
  $assignment_js = " $(document).ready(function() {
  	var curWhere;
    $('#edit-feedback-type').change(function() {
    	var curType = $('#edit-feedback-type').val();
      if (curType == '1') {
      		$('#edit-completion-time-wrapper').show();
      	} else {
      		$('#edit-completion-time-wrapper').hide();
      	}
    });

    $('#edit-feedback-where-1').change(function() {
    	curWhere = $('#edit-feedback-where-1').val();
      if (curWhere == '1') {
      	$('#edit-timing-wrapper').hide();
      }
    });
    $('#edit-feedback-where-2').change(function() {
    	curWhere = $('#edit-feedback-where-2').val();
      if (curWhere == '2') {
      	$('#edit-timing-wrapper').show();
      }
    });
    $('#edit-feedback-where-3').change(function() {
    	curWhere = $('#edit-feedback-where-3').val();
      if (curWhere == '3') {
      	$('#edit-timing-wrapper').show();
      }
    });

		curWhere = $('#edit-feedback-where-1:checked').val();
		if (curWhere == '1') {
			$('#edit-timing-wrapper').hide();
		}
		curWhere = $('#edit-feedback-where-2:checked').val();
		if (curWhere == '2') {
			$('#edit-timing-wrapper').show();
		}
		curWhere = $('#edit-feedback-where-3:checked').val();
		if (curWhere == '3') {
			$('#edit-timing-wrapper').show();
		}

    $('#edit-feedback-type').trigger('change');
  });";
  drupal_add_js($assignment_js, 'inline', 'header');

  $form['name'] = array(
    '#type' => 'textfield',
    '#title' => t('Your username'),
    '#size' => 30,
    '#value' => $user_data->name,
    '#disabled' => TRUE,
  );

  $form['tutorial_name'] = array(
    '#type' => 'textfield',
    '#title' => t('Name of the Tutorial'),
    '#size' => 30,
    '#value' => $node_data->title,
    '#disabled' => TRUE,
  );

  $form['feedback_type'] = array(
    '#type' => 'select',
    '#title' => t('Feedback Type'),
    '#default_value' => $feedback_data->feedback_type,
    '#options' => _feedback_type(),
    '#required' => TRUE,
  );

  $form['feedback_where'] = array(
    '#type' => 'radios',
    '#title' => t('Where'),
    '#default_value' => $feedback_data->feedback_where,
    '#options' => _feedback_where(),
    '#required' => TRUE,
  );

  $form['timing'] = array(
    '#type' => 'textfield',
    '#title' => t('Start Time'),
    '#description' => t('Example : 02:40 for 2 minutes 40 seconds from the start of tutorial'),
    '#size' => 5,
    '#maxlength' => 5,
    '#default_value' => $feedback_data->timing,
  );

  $form['completion_time'] = array(
    '#type' => 'textfield',
    '#title' => t('How long did you take to complete the assignment'),
    '#size' => 2,
    '#maxlength' => 2,
    '#field_suffix' => 'minutes',
    '#default_value' => $feedback_data->completion_time,
  );

  $form['comments'] = array(
    '#type' => 'textarea',
    '#title' => t('Comment Box'),
    '#description' => t('Enter your comments, questions or suggestions here'),
    '#rows' => 12,
    '#default_value' => $feedback_data->comments,
    '#required' => TRUE,
  );

  /* file attachments */
  $attachment_q = db_query("SELECT * FROM {assignment_feedback_attachments} WHERE submission_id = %d", $feedback_id);
  if ($attach1_data = db_fetch_object($attachment_q)) {
		$form['attach1'] = array(
			'#type' => 'item',
			'#title' => t('Attachment 1'),
			'#value' => l($attach1_data->filename, $attach1_data->filepath),
		);
		if ($attach2_data = db_fetch_object($attachment_q)) {
			$form['attach2'] = array(
				'#type' => 'item',
				'#title' => t('Attachment 2'),
				'#value' => l($attach2_data->filename, $attach2_data->filepath),
			);
			if ($attach3_data = db_fetch_object($attachment_q)) {
				$form['attach3'] = array(
					'#type' => 'item',
					'#title' => t('Attachment 2'),
					'#value' => l($attach3_data->filename, $attach3_data->filepath),
				);
			}
		}
	}

  $form['delete_feedback'] = array(
    '#type' => 'checkbox',
    '#title' => t('Delete Feedback'),
  );

  $form['submit'] = array(
    '#type' => 'submit',
    '#value' => t('Submit')
  );

  $form['cancel'] = array(
    '#type' => 'markup',
    '#value' => l(t('Cancel'), 'feedback/manage'),
  );

  return $form;
}

function edit_feedback_form_submit($form, &$form_state)
{
	global $user;
  $root_path = _root_path();
  $folder_path =  'sites/default/files/assignment/';

	$feedback_id = (int)arg(3);
	$feedback_q = db_query("SELECT * FROM assignment_feedback_submissions WHERE id = %d LIMIT 1", $feedback_id);
	$feedback_data = db_fetch_object($feedback_q);
	if (!$feedback_data) {
		drupal_set_message(t('Invalid Feedback'), 'error');
		drupal_goto('feedback/manage');
		return;
	}
	$user_data = user_load($feedback_data->uid);
	$node_data = node_load($feedback_data->nid);

	/* delete feedback option selected */ 
	if ($form_state['values']['delete_feedback'] == 1) {

		/* delete attachments */
		$status = TRUE;
		$attachment_q = db_query("SELECT * FROM {assignment_feedback_attachments} WHERE submission_id = %d", $feedback_id);
		while ($attachment_data = db_fetch_object($attachment_q))
		{
			if (!file_exists($root_path . $attachment_data->filepath))
			{
				drupal_set_message('Error deleting file :' . $attachment_data->filepath . '. File does not exists.', 'error');
				continue;
			}

			/* removing file */
			if (!unlink($root_path . $attachment_data->filepath))
			{
				drupal_set_message('Error deleting file:' . $attachment_data->filepath, 'error');
				$status = FALSE;
			} else {
				/* deleting example files database entries */
				db_query("DELETE FROM {assignment_feedback_attachments} WHERE id = %d", $attachment_data->id);
			}
		}
		if (!$status) {
			drupal_set_message(t('Feedback cannot be deleted!'), 'error');
			drupal_goto('feedback/manage');
			return;
		}

		/* delete feedback */
		db_query("DELETE FROM {assignment_feedback_submissions} WHERE id = %d", $feedback_id);
		drupal_set_message(t('Feedback has been deleted!'), 'status');
		drupal_goto('feedback/manage');
		return;
	}

	$timing = $form_state['values']['timing'];
	$completion_time = $form_state['values']['completion_time'];

	if ($form_state['values']['feedback_where'] == 1) {
		$timing = "00:00";
	}

	if ($form_state['values']['feedback_type'] != 1) {
		$completion_time = 0;
	}

	/* update feedback */
	db_query("UPDATE {assignment_feedback_submissions} SET feedback_type = %d, feedback_where = %d, timing = '%s', completion_time = %d, comments = '%s' WHERE id = %d",
						$form_state['values']['feedback_type'],
						$form_state['values']['feedback_where'],
						$timing,
						$completion_time,
						$form_state['values']['comments'],
						$feedback_id
						);

	drupal_set_message(t('Feedback No. ' . $feedback_id . ' has been updated!'), 'status');
	drupal_goto('feedback/manage');
	return;
}

/******************************************************************************/
/***************************** LIST OF FEEDBACK *******************************/
/******************************************************************************/

function _pending_feedbacks()
{
	$pending_q = db_query("SELECT * FROM {assignment_feedback_submissions} WHERE status = 0 ORDER BY id DESC");
	if (!$pending_q) {
		drupal_set_message(t('There are no pending feedback.'), 'status');
		return '';
	}
	$pending_rows = array();
	while ($pending_data = db_fetch_object($pending_q)) {
		$pending_rows[] = array(
				$pending_data->id,
				date('d-m-Y', $pending_data->timestamp),
				l(node_load($pending_data->nid)->title, 'node/' . $pending_data->nid),
				l(user_load($pending_data->uid)->name, 'user/' . $pending_data->uid),
				_feedback_type($pending_data->feedback_type),
				l('Approve', 'feedback/manage/approve/' . $pending_data->id) . ' | ' . l('Edit', 'feedback/manage/edit/' . $pending_data->id)
			);
	}
  $pending_header = array('Id', 'Date of Submission', 'Name of the Tutorial', 'User Name', 'Type', 'Action');
  $output = theme_table($pending_header, $pending_rows);
  return $output; 
}

function all_feedbacks_form($form_state)
{
	$form['#redirect'] = FALSE;

  $form['feedback_status'] = array(
    '#type' => 'radios',
    '#title' => t('Feedback Status'),
    '#options' => array('-1' => 'All', '0' => 'Pending', '1' => 'Approved', '2' => 'Disapproved'),
    '#default_value' => -1,
  );

  $form['feedback_type'] = array(
    '#type' => 'radios',
    '#title' => t('Feedback Type'),
    '#options' => array('0' => 'All', '1' => 'Assignment', '2' => 'Feedback', '3' => 'Correction', '4' => 'Question', '5' => 'Suggestions', '6' => 'Others'),
    '#default_value' => 0,
  );

  $form['from'] = array(
    '#type' => 'textfield',
    '#title' => t('From Date'),
    '#size' => 10,
    '#description' => t('Format: DD-MM-YYYY'),
  );

  $form['to'] = array(
    '#type' => 'textfield',
    '#title' => t('To Date'),
    '#size' => 10,
    '#description' => t('Format: DD-MM-YYYY'),
  );

  $form['approver'] = array(
    '#type' => 'select',
    '#title' => t('Approver'),
    '#options' => _all_users(),
  );

  $form['username'] = array(
    '#type' => 'select',
    '#title' => t('Username'),
    '#options' => _all_users(),
  );

  $form['submit'] = array(
    '#type' => 'submit',
    '#value' => t('Search'),
  );

  if ($_POST) {
  	$query_str = '';

		if ($_POST['feedback_status'] >= 0)
  			$query_str .= " AND status = " . $_POST['feedback_status'];

  		if ($_POST['from'])
  		$query_str .= " AND timestamp >= " . _to_timestamp($_POST['from'], 'F') . " ";

  	if ($_POST['to'])
  		$query_str .= " AND timestamp <= " . _to_timestamp($_POST['to'], 'T') . " ";

  	if ($_POST['approver']) {
  		if ($_POST['approver'] > 0)
  			$query_str .= " AND approver_uid = " . $_POST['approver'] . " ";
  	}

  	if ($_POST['username']) {
  		if ($_POST['username'] > 0)
  			$query_str .= " AND uid = " . $_POST['username'] . " ";
  	}

  	if ($_POST['feedback_type']) {
  		if ($_POST['feedback_type'] > 0)
  			$query_str .= " AND feedback_type = " . $_POST['feedback_type'] . " ";
  	}

  	$query_str = "SELECT * FROM {assignment_feedback_submissions} WHERE 1 " . $query_str . " ORDER BY timestamp DESC";
  	drupal_set_message($query_str, 'status');
  	$search_q = db_query($query_str);
  	$output = '';
  	while ($search_data = db_fetch_object($search_q)) {
  		$search_rows[] = array(
				$search_data->id,
				date('d-m-Y G:i', $search_data->timestamp),
				l(node_load($search_data->nid)->title, 'node/' . $search_data->nid),
				l(user_load($search_data->uid)->name, 'user/' . $search_data->uid),
				($search_data->approver_uid) ? l(user_load($search_data->approver_uid)->name, 'user/' . $search_data->approver_uid) : '-',
				_feedback_type($search_data->feedback_type),
				_feedback_status($search_data->status),
				l('Approve', 'feedback/manage/approve/' . $search_data->id) . ' | ' . l('Edit', 'feedback/manage/edit/' . $search_data->id)
			);
			$search_header = array('Id', 'Date of Submission', 'Name of the Tutorial', 'User Name', 'Approver', 'Type', 'Status', 'Action');
			$output = theme_table($search_header, $search_rows);
  	}
		$form['results'] = array(
			'#type' => 'item',
			'#value' => $output,
		);
	}

  return $form;
}

function _all_users()
{
	$user_q = db_query("SELECT * FROM {users} ORDER BY name ASC");
	while ($user_data = db_fetch_object($user_q)) {
		$user_rows[$user_data->uid] = $user_data->name;
	}
	$user_rows[0] = 'All';
	return $user_rows;
}

function _to_timestamp($str, $from_to)
{
	$timearr = explode('-', $str);
	if ($from_to == 'F')
		return mktime(0, 0, 0, $timearr[1], $timearr[0], $timearr[2]);
	else
		return mktime(23, 59, 59, $timearr[1], $timearr[0], $timearr[2]);
}

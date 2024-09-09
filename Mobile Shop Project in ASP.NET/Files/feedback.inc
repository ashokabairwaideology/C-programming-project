<?php
// $Id$

function add_feedback_form($form_state)
{
	global $user;

	$nid = (int)arg(2);
	$node_data = node_load($nid);
	if (!$node_data) {
		drupal_set_message(t('Invalid Link'), 'error');
		drupal_goto('');
	}

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

  $form['#attributes'] = array('enctype' => "multipart/form-data");

  $form['name'] = array(
    '#type' => 'textfield',
    '#title' => t('Your username'),
    '#size' => 30,
    '#value' => $user->name,
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
    '#default_value' => 0,
    '#options' => _feedback_type(),
    '#required' => TRUE,
  );

  $form['feedback_where'] = array(
    '#type' => 'radios',
    '#title' => t('Where'),
    '#default_value' => 1,
    '#options' => _feedback_where(),
    '#required' => TRUE,
  );

  $form['timing'] = array(
    '#type' => 'textfield',
    '#title' => t('Start Time'),
    '#description' => t('Example : 02:40 for 2 minutes 40 seconds from the start of tutorial'),
    '#size' => 5,
    '#maxlength' => 5,
    '#default_value' => '00:00',
  );

  $form['completion_time'] = array(
    '#type' => 'textfield',
    '#title' => t('How long did you take to complete the assignment'),
    '#size' => 2,
    '#maxlength' => 2,
    '#field_suffix' => 'minutes',
  );

  $form['comments'] = array(
    '#type' => 'textarea',
    '#title' => t('Comment Box'),
    '#description' => t('Enter your comments, questions or suggestions here'),
    '#rows' => 12,
    '#required' => TRUE,
  );

  $form['attach1'] = array(
    '#type' => 'file',
    '#title' => t('Attachment 1'),
    '#description' => t('Separate filenames with underscore. No spaces or any special characters allowed in filename.') . '<br />' .
    	t('Allowed file extensions : ') . variable_get('assignment_feedback_upload_extensions', ''),
  );

  $form['attach2'] = array(
    '#type' => 'file',
    '#title' => t('Attachment 2'),
    '#description' => t('Separate filenames with underscore. No spaces or any special characters allowed in filename.') . '<br />' .
    	t('Allowed file extensions : ') . variable_get('assignment_feedback_upload_extensions', ''),
  );

  $form['attach3'] = array(
    '#type' => 'file',
    '#title' => t('Attachment 3'),
    '#description' => t('Separate filenames with underscore. No spaces or any special characters allowed in filename.') . '<br />' .
    	t('Allowed file extensions : ') . variable_get('assignment_feedback_upload_extensions', ''),
  );

  $form['submit'] = array(
    '#type' => 'submit',
    '#value' => t('Submit Feedback'),
  );

  return $form;
}

function add_feedback_form_validate($form, &$form_state)
{

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

  if ($form_state['values']['feedback_type'] < 1)
    form_set_error('feedback_type', t('Feedback Type field is required.'));
  if (!preg_match('/^[0-9][0-9]:[0-9][0-9]$/', $form_state['values']['timing']))
    form_set_error('timing', t('Start Time is not in a valid format (eg: 00:00).'));
  if ($form_state['values']['completion_time'])
  	if (!preg_match('/^\d+$/', $form_state['values']['completion_time']))
    	form_set_error('completion_time', t('How long did you take to complete the assignment is not a valid time.'));

    /* check for valid filename extensions */  
    foreach ($_FILES['files']['name'] as $file_form_name => $file_name)
    {
      if ($file_name)
      {
        $allowed_extensions = explode(',' , variable_get('assignment_feedback_upload_extensions', ''));
        $temp_extension = end(explode('.', strtolower($_FILES['files']['name'][$file_form_name])));
        if (!in_array($temp_extension, $allowed_extensions))
          form_set_error($file_form_name, t('Only file with ' . variable_get('assignment_feedback_upload_extensions', '') . ' extensions can be uploaded.'));
        if ($_FILES['files']['size'][$file_form_name] <= 0)
          form_set_error($file_form_name, t('File size cannot be zero.'));

        /* check if valid file name */
        if (!_check_valid_filename($_FILES['files']['name'][$file_form_name]))
         form_set_error($file_form_name, t('Invalid file name specified. Only alphabets, numbers and underscore is allowed as a valid filename.'));
      }
    }
}

function add_feedback_form_submit($form, &$form_state)
{
	global $user;
  $root_path = _root_path();
  $folder_path =  'sites/default/files/assignment/';

	$nid = (int)arg(2);
	$node_data = node_load($nid);
	if (!$node_data) {
		drupal_set_message(t('Invalid Link'), 'error');
		drupal_goto('');
	}

	$timing = $form_state['values']['timing'];
	$completion_time = $form_state['values']['completion_time'];

	if ($form_state['values']['feedback_where'] == 1) {
		$timing = "00:00";
	}

	if ($form_state['values']['feedback_type'] != 1) {
		$completion_time = 0;
	}

	db_query("INSERT INTO {assignment_feedback_submissions} (uid, nid, feedback_type, feedback_where, timing, completion_time, comments, status, timestamp, approver_uid, approver_timestamp)
						VALUES (%d, %d, %d, %d, '%s', %d, '%s', %d, %d, %d, %d)",
						$user->uid,
						$nid,
						$form_state['values']['feedback_type'],
						$form_state['values']['feedback_where'],
						$timing,
						$completion_time,
						$form_state['values']['comments'],
						0,
						time(),
						0,
						time()
						);

	$submission_id = db_last_insert_id('assignment_feedback_submissions', 'id');

  /* uploading files */
  foreach ($_FILES['files']['name'] as $file_form_name => $file_name)
  {
    if ($file_name)
    {
    	$upload_filename = $_FILES['files']['name'][$file_form_name];
    	$counter = 1;
      while (file_exists($root_path . $folder_path . $upload_filename)) {
      	$upload_filename = $counter . $_FILES['files']['name'][$file_form_name];
      	$counter++;
      }

      /* uploading file */
      if (move_uploaded_file($_FILES['files']['tmp_name'][$file_form_name], $root_path . $folder_path . $upload_filename))
      {
        /* for uploaded files making an entry in the database */
        db_query("INSERT INTO {assignment_feedback_attachments} (submission_id, filename, filepath, filemime, filesize, timestamp)
          VALUES (%d, '%s', '%s', '%s', %d, %d)",
          $submission_id,
          $upload_filename,
          $folder_path . $upload_filename,
          $_FILES['files']['type'][$file_form_name],
          $_FILES['files']['size'][$file_form_name],
          time()
          );
      } else {
        drupal_set_message('Error uploading file : ' . $_FILES['files']['name'][$file_form_name], 'error');
      }
    }
  }

	/* sending email */
	$email_to = $user->mail;
	$param['feedback_received']['user_id'] = $user->uid;
	$param['feedback_received']['tutorial_name'] = $node_data->title;
	$param['feedback_received']['feedback_type'] = _feedback_type($form_state['values']['feedback_type']); 
	$param['feedback_received']['feedback_where'] = _feedback_where($form_state['values']['feedback_where']);
	$param['feedback_received']['timing'] = $form_state['values']['timing'];
	$param['feedback_received']['completion_time'] = $form_state['values']['completion_time'];
	$param['feedback_received']['comments'] = $form_state['values']['comments'];
	if (!drupal_mail('assignment_feedback', 'feedback_received', $email_to, language_default(), $param, variable_get('textbook_companion_from_email', NULL), TRUE))
		drupal_set_message('Error sending email message.', 'error');
	$email_to = variable_get('assignment_feedback_emails', NULL);
	if (!drupal_mail('assignment_feedback', 'feedback_received', $email_to, language_default(), $param, variable_get('textbook_companion_from_email', NULL), TRUE))
		drupal_set_message('Error sending email message.', 'error');

	drupal_set_message(t('Thank you for your feedback!'), 'status');
	drupal_goto('node/' . $nid);
}


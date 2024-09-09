<?php
// $Id$

function show_feedback_form($form_state)
{
	global $user;

	$form['#redirect'] = FALSE;

	ahah_helper_register($form, $form_state);

  if (!isset($form_state['storage']['show']['feedback_type']))
  {
		$nid = (int)arg(2);
		$node_data = node_load($nid);
		if (!$node_data) {
			drupal_set_message(t('Invalid Link'), 'error');
			drupal_goto('');
		}
    $feedback_type_default_value = 0;
  } else {
  	$node_data = node_load($form_state['values']['show']['nid_hidden']);
    $feedback_type_default_value = $form_state['storage']['show']['feedback_type'];
  }

  $form['show'] = array(
    '#type' => 'fieldset',
    '#title' => t('Show Feedback'),
    '#collapsible' => FALSE,
    '#collapsed' => FALSE,
    '#prefix' => '<div id="show-wrapper">',
    '#suffix' => '</div>',
    '#tree' => TRUE,
  );

  $form['show']['tutorial_name'] = array(
    '#type' => 'textfield',
    '#title' => t('Name of the Tutorial'),
    '#size' => 30,
    '#value' => $node_data->title,
    '#disabled' => TRUE,
  );

  $form['show']['feedback_type'] = array(
    '#type' => 'select',
    '#title' => t('Feedback Type'),
    '#default_value' => $feedback_type_default_value,
    '#options' => array('0' => 'All', '1' => 'Assignment', '2' => 'Feedback', '3' => 'Correction', '4' => 'Question', '5' => 'Suggestions', '6' => 'Others'),
		'#tree' => TRUE,
		'#ahah' => array(
			'event'   => 'change',
			'effect' => 'none',
			'path'    => ahah_helper_path(array('show')),
			'wrapper' => 'show-wrapper',
			'progress' => array(
				'type' => 'throbber',
				'message' => t(''),
			),
		),
  );

  $form['show']['back'] = array(
    '#type' => 'item',
    '#value' => l('Back to content', 'node/' . $node_data->nid),
  );

 	if ($form_state['storage']['show']['feedback_type'] > 0)
 		$search_q = db_query("SELECT * FROM {assignment_feedback_submissions} WHERE nid = %d AND feedback_type = %d AND status = 1 ORDER BY timestamp DESC", $node_data->nid, $feedback_type_default_value);
 	else
 		$search_q = db_query("SELECT * FROM {assignment_feedback_submissions} WHERE nid = %d AND status = 1 ORDER BY timestamp DESC", $node_data->nid);

	$output = '';
	while ($search_data = db_fetch_object($search_q)) {
		$show_comments = "";
		if ($search_data->timing != "00:00")
			$show_comments .= "[" . $search_data->timing . "] ";
		$show_comments .= $search_data->comments;
		$files_q = db_query("SELECT * FROM {assignment_feedback_attachments} WHERE submission_id = %d", $search_data->id);
		while ($files_data = db_fetch_object($files_q)) {
			$show_comments .= "<br />" . l($files_data->filename, $files_data->filepath);  
		}

		$search_rows[] = array(
			date('d-m-Y', $search_data->timestamp),
			l(user_load($search_data->uid)->name, 'user/' . $search_data->uid),
			_feedback_type($search_data->feedback_type),
			$show_comments,
		);
		$search_header = array('Date of Submission', 'User Name', 'Type', 'Comments');
		$output = theme_table($search_header, $search_rows);

    $form['show']['feedback_type_details'] = array(
      '#type' => 'item',
      '#value' => $output,
    );
  }

  /* hidden form elements */
  $form['show']['nid_hidden'] = array(
    '#type'  => 'hidden',
    '#value' =>  $node_data->nid,
  );
  $form['show']['feedback_type_hidden'] = array(
    '#type'  => 'hidden',
    '#value' =>  $form_state['values']['show']['feedback_type'],
  );

  return $form;
}

function show_feedback_form_submit($form, &$form_state)
{
	global $user;
}

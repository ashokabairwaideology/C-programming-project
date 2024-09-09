<?php
// $Id$

function assignment_feedback_settings_form($form_state)
{
  $form['emails'] = array(
    '#type' => 'textfield',
    '#title' => t('Notification emails'),
    '#description' => t('A comma separated list of email addresses to receive notifications emails'),
    '#size' => 50,
    '#maxlength' => 255,
    '#required' => TRUE,
    '#default_value' => variable_get('assignment_feedback_emails', ''),
  );

  $form['from_email'] = array(
    '#type' => 'textfield',
    '#title' => t('Outgoing from email address'),
    '#description' => t('Email address to be display in the from field of all outgoing messages'),
    '#size' => 50,
    '#maxlength' => 255,
    '#required' => TRUE,
    '#default_value' => variable_get('assignment_feedback_from_email', ''),
  );

  $form['upload_extensions'] = array(
    '#type' => 'textfield',
    '#title' => t('Allowed source file extensions'),
    '#description' => t('A comma separated list WITHOUT SPACE of file extensions that are permitted to be uploaded on the server'),
    '#size' => 50,
    '#maxlength' => 255,
    '#required' => TRUE,
    '#default_value' => variable_get('assignment_feedback_upload_extensions', ''),
  );

  $node_types = array_map('check_plain', node_get_types('names'));
  $form['node_types'] = array(
    '#type' => 'checkboxes',
    '#title' => t('Show link in following node types'),
    '#description' => t('Show link in following node types'),
    '#options' => $node_types,
    '#default_value' => variable_get('assignment_feedback_node_types', array()),
  );

  $form['submit'] = array(
    '#type' => 'submit',
    '#value' => t('Submit')
  );
  return $form;
}

function assignment_feedback_settings_form_submit($form, &$form_state)
{
	$node_types = array();
	foreach ($form_state['values']['node_types'] as $ntype => $nstate) {
		if ($nstate)
			$node_types[] = $ntype;
	}
  variable_set('assignment_feedback_emails', $form_state['values']['emails']);
  variable_set('assignment_feedback_from_email', $form_state['values']['from_email']);
  variable_set('assignment_feedback_upload_extensions', $form_state['values']['upload_extensions']);
  variable_set('assignment_feedback_node_types', $node_types);
  drupal_set_message(t('Settings updated'), 'status');
}

<?php

class Contact extends Controller {

	function Contact()
	{
		parent::Controller();
	}
	
	function index()
	{
		$data['page_class'] = 'contact';
		$this->heading = 'Contact';
		$this->load->view('content/contact', $data);
	}
		
}
?>
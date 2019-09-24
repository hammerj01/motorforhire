<?php

class About extends Controller {

	function About()
	{
		parent::Controller();	
	}
	
	function index()
	{
		$data['page_class'] = 'about';
		$this->heading = 'About';
		$this->load->view('content/about', $data);
	}
	
	function methods()
	{
		$data['page_class'] = 'about';
		$this->heading = '3 Methods to Obtain Contact Hours';
		$this->load->view('content/methods', $data);
	}
	
	function alphanet()
	{
		$data['page_class'] = 'about';
		$this->heading = 'About AlphaNet and Alpha-1';
		$this->load->view('content/alphanet', $data);
	}
}
?>
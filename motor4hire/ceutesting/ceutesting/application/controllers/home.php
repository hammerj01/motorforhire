<?php

class Home extends Controller {

	function Home()
	{
		parent::Controller();	
	}
	
	function index()
	{
		$data['page_class'] = 'home';
		$this->heading = 'Home';
		$this->load->view('content/home', $data);
	}

}
?>
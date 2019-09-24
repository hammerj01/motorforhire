<?php

class Video extends Controller {

	function Video()
	{
		parent::Controller();
	}
	
	function index()
	{
		$data['page_class'] = 'video';
		$this->heading = 'Alpha-1 Antitrypsin Deficiency and Augmentation Therapy (Prolastin)';
		$this->load->view('content/video', $data);
	}
		
}
?>
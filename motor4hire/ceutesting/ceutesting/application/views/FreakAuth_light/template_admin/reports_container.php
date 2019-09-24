<?php
$this->load->view($this->config->item('FAL_template_dir').'template_admin/header');
switch ($report_name) {
	case "Pass, Fail, In Progress":
		$this->load->view($this->config->item('FAL_template_dir').'template_admin/reports_all');
		break;
	case "Passed":
		$this->load->view($this->config->item('FAL_template_dir').'template_admin/reports_pass');
		break;
	case "Failed":
		$this->load->view($this->config->item('FAL_template_dir').'template_admin/reports_fail');
		break;
	case "Search":
		$this->load->view($this->config->item('FAL_template_dir').'template_admin/reports_search');
		break;
	default:
		$this->load->view($this->config->item('FAL_template_dir').'template_admin/reports_progress');
		break;
}

$this->load->view($this->config->item('FAL_template_dir').'template_admin/footer');
?> 

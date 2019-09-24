<?php
/**
 * Auth Controller Class
 *
 * Security controller that provides functionality to handle logins, logout and registration
 * requests.  It also can verify the logged in status of a user and his permissions.
 *
 * The class requires the use of the DB_Session and FreakAuth libraries.
 *
 * @package     FreakAuth
 * @subpackage  Controllers
 * @category    Administration
 get_status* @author      Daniel Vecchiato (danfreak)
 * @copyright   Copyright (c) 2007, 4webby.com
 * @license		http://www.gnu.org/licenses/lgpl.html
 * @link 		http://4webby.com/freakauth
 * @version 	1.1
 *
 */

class AdminHome extends Controller
{	
	/**
	 * Initialises the controller
	 *
	 * @return Admin
	 */
    function AdminHome()
    {
        parent::Controller();
        
        ////////////////////////////
		//CHECKING FOR PERMISSIONS
		///////////////////////////
		//-------------------------------------------------
        //only 'admin' and 'superadmin' can manage users
        
        $this->freakauth_light->check('user');
        
        //-------------------------------------------------
        //END CHECKING FOR PERMISSION
        
		$this->_container = $this->config->item('FAL_template_dir').'template_admin/container';
        
    }
	
    	// --------------------------------------------------------------------
	
    /**
     * Displays home page of Admin Console
     *
     */
    function index()
    {	   
		$this->heading = 'Dashboard';
		//If the person logged in is not an administrator, get their test status: Pass, Fail, Complete or Progress
		if(!isAdmin()){
			$data = $this->get_status();
			
		} else {
		    	
			$data = $this->get_reporting_data();
		}
	    
		$data['page_class'] = 'dashboard';
		$this->load->view($this->_container, $data);
    }

	function get_status()
	{	
		$this->db->select('status, score');
		$this->db->where('user_id', getUserProperty('id'));
		$query = $this->db->get('prolastin');

		if ($query->num_rows() > 0)
		{
			foreach ($query->result() as $row)
			{
				$data['status'] = $row->status;
				$data['score'] = $row->score;
			}
		} else {
			$data['status'] = "";
		}
	
	$data['expiration_date'] = $this->getExpires(getUserProperty('id'));
//  	var_dump($data);
 		return $data;
	}
	
	function get_reporting_data()
	{
		//get the number of people who have stared the test
		$data['total'] = $this->db->count_all('prolastin');
		
		//get the number of people who have passed the test
		$query = $this->db->query('SELECT * FROM prolastin WHERE status="pass" OR status="complete"');
		$data['pass'] = $query->num_rows();
		
		//get the number of people who have failed the test
		$query = $this->db->query('SELECT * FROM prolastin WHERE status="fail"');
		$data['fail'] = $query->num_rows();
		
		//get the number of tests in progress
		$data['progress'] = $data['total'] - ($data['pass'] + $data['fail']);
		return $data;
	}
	
	function getExpires($id){
	    $query = $this->db->query('SELECT p.status, p.complete_date, c.certificate_number, c.certificate_number_type, c.expires, c.footer_language FROM prolastin p INNER JOIN certificate c ON c.id = p.certificate_id WHERE p.user_id='.$id);
	   
	    if ($query->num_rows()>0) {
            $i = 1;
            foreach ($query->result() as $row) {
                $data['status'] = $row->status;
                $data['complete_date'] = $row->complete_date;
                $data['certificate_number'] = $row->certificate_number;
                $data['certificate_number_type'] = $row->certificate_number_type;
                $data['expiration_date'] = $row->expires;
                $data['footer_language'] = $row->footer_language;
                $i = $i+1;
            }
            $expiration_date = $data['expiration_date'];
        }else{
             $expiration_date = NULL;
        }
        
        return $expiration_date;
	}
	
}
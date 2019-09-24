<?php
/**
 * Auth Controller Class
 *
 * Security controller that provides functionality to handle logins, logout, registration
 * and forgotten password requests.  
 * It also can verify the logged in status of a user and his permissions.
 *
 * The class requires the use of the DB_Session and FreakAuth libraries.
 *
 * @package     FreakAuth_light
 * @subpackage  Controllers
 * @category    Authentication
 * @author      Daniel Vecchiato (danfreak)
 * @copyright   Copyright (c) 2007, 4webby.com
 * @license		http://www.gnu.org/licenses/lgpl.html
 * @link 		http://4webby.com/freakAuth
 * @version 	1.1
 *
 */

class Auth extends Controller
{	
	/**
	 * Initialises the controller
	 *
	 * @return Auth
	 */
    function Auth()
    {
        parent::Controller();
        
        $this->load->library('FAL_front', 'fal_front');
        
        $this->_container = $this->config->item('FAL_template_dir').'template/container';
    }
	
    // --------------------------------------------------------------------
	
    /**
     * Displays the login form.
     *
     */
    function index()
    {	    	
    	$this->login();    
    }
    
    // --------------------------------------------------------------------
    
	/**
     * Displays the login form.
     *
     */
    function login()
    {	    	
    	$this->heading = 'Login';
		$data['page_class'] = 'login onecolumn';
		$data['fal'] = $this->fal_front->login();
    	$this->load->view($this->_container, $data);     
    }

    // --------------------------------------------------------------------
    
    /**
     * Handles the logout action.
     *
     */
    function logout()
    {
        $this->fal_front->logout();
    }
    
	// --------------------------------------------------------------------
	
    /**
     * Handles the post from the registration form.
     *
     */
    
    function register()
    {	        
    	$this->heading = 'Register';
		$data['page_class'] = 'register onecolumn';
		//Load state helper
		$this->load->helper('state');
		
		//displays the view
		$data['fal'] = $this->myfal->_register();
    	$this->load->view($this->_container, $data);
    }
    
    // --------------------------------------------------------------------
    
    /**
     * Handles the user activation.
     *
     */
    function activation()
    {	
		$data['fal'] = $this->fal_front->activation();
		$this->load->view($this->_container, $data); 
    }
    
	// --------------------------------------------------------------------
	
    /**
     * Handles the post from the forgotten password form.
     *
     */
    function forgotten_password()
    {	
		$this->heading = 'Forgot Password';

		$data['page_class'] = 'onecolumn';
		$data['heading'] = $this->lang->line('FAL_forgotten_password_label');
    	$data['fal'] = $this->fal_front->forgotten_password();
		$this->load->view($this->_container, $data); 
    }
    
	// --------------------------------------------------------------------
	
    /**
     * Displays the forgotten password reset.
     *
     */
    function forgotten_password_reset()
    {	
       $this->heading = 'Reset Password';
	   
	   $data['page_class'] = 'onecolumn';
	   $data['heading'] = $this->lang->line('FAL_forgotten_password_label');
       $data['fal'] = $this->fal_front->forgotten_password_reset();
	   $this->load->view($this->_container, $data);      
    }

    
    // --------------------------------------------------------------------
    
    /**
     * Function that handles the change password procedure
     * needed to let the user set the password he wants after the
     * forgotten_password_reset() procedure
     *
     */
    function changepassword()
    {
       $this->heading = 'Change Password';
	   $data['page_class'] = 'onecolumn';
	   $data['heading'] = $this->lang->line('FAL_change_password_label');
       $data['fal'] = $this->fal_front->changepassword();
	   $this->load->view($this->_container, $data);     
    }
}
?>
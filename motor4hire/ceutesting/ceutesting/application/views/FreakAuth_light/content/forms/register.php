<h2>Register to take the course</h2>
<?php if ($this->fal_validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->fal_validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>
<p>Health Care Professionals must register to take the course, complete the evaluation and print their certificate. Registering also allows you to save your test progress and retake the test. Already registered? <?=anchor($this->config->item('FAL_login_uri'), 'Login here')?>.</p>
<p><span class="notice">* All fields required</span></p>

<?=form_open($this->uri->uri_string(), array('id' => 'register_form'))?>

<dl class="two_column">
<!-- USERNAME -->
	<dt><label for="user_name"><?=$this->lang->line('FAL_user_name_label')?></label></dt>
	<dd><?=form_input(array('name'=>'user_name', 
	                       'id'=>'user_name',
	                       'maxlength'=>'45', 
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'user_name'} : '')))?>
	<dd class="clear"><hr /></dd>

<!-- PASSWORD -->	
	<dt><label for="password"><?=$this->lang->line('FAL_user_password_label')?></label></dt>
	<dd><?=form_password(array('name'=>'password', 
	                       'id'=>'password',
	                       'maxlength'=>'16', 
						   'class'=>'full',
	                       'value'=>''))?>
	<dd class="clear"><hr /></dd>

<!-- CONFIRM PASSWORD -->
	<dt><label for="password_confirm"><?=$this->lang->line('FAL_user_password_confirm_label')?></label></dt>
	<dd><?=form_password(array('name'=>'password_confirm', 
	                       'id'=>'password_confirm',
	                       'maxlength'=>'16', 
						   'class'=>'full',
	                       'value'=>''))?>
	<dd class="clear"><hr /></dd>

<!-- EMAIL -->
	<dt><label for="email"><?=$this->lang->line('FAL_user_email_label')?></label></dt>
	<dd><?=form_input(array('name'=>'email', 
	                       'id'=>'email',
	                       'maxlength'=>'120', 
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'email'} : '')))?>
	<dd class="clear"><hr /></dd>

<!-- FIRST NAME -->
	<dt><label for="first_name"><?=$this->lang->line('FAL_user_first_name_label')?></label></dt>
	<dd><?=form_input(array('name'=>'first_name', 
	                       'id'=>'first_name',
	                       'maxlength'=>'100',
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'first_name'} : '')))?>
	<dd class="clear"><hr /></dd>
	
<!-- LAST NAME -->
	<dt><label for="last_name"><?=$this->lang->line('FAL_user_last_name_label')?></label></dt>
	<dd><?=form_input(array('name'=>'last_name', 
	                       'id'=>'last_name',
	                       'maxlength'=>'100',
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'last_name'} : '')))?>
	<dd class="clear"><hr /></dd>
	
<!-- ADDRESS -->
	<dt><label for="address"><?=$this->lang->line('FAL_user_address_label')?></label></dt>
	<dd><?=form_input(array('name'=>'address', 
	                       'id'=>'address',
	                       'maxlength'=>'200',
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'address'} : '')))?>
	<dd class="note">Format: <strong>1807 Hendricks Ave.</strong></dd>
	<dd class="clear"><hr /></dd>
	<?php $options = array("Alabama"=>"AL", "Alaska"=>"AK", "Arizona"=>"AZ", "Arkansas"=>"AR", "California"=>"CA", "Colorado"=>"CO", "Connecticut"=>"CT", "Delaware"=>"DE", "D.C."=>"DC", "Florida"=>"FL", "Georgia"=>"GA", "Hawaii"=>"HI", "Idaho"=>"ID", "Illinois"=>"IL", "Indiana"=>"IN", "Iowa"=>"IA", "Kansas"=>"KS", "Kentucky"=>"KY", "Louisiana"=>"LA", "Maine"=>"ME", "Maryland"=>"MD", "Massachusetts"=>"MA", "Michigan"=>"MI", "Minnesota"=>"MN", "Mississippi"=>"MS", "Missouri"=>"MO", "Montana"=>"MT", "Nebraska"=>"NE", "Nevada"=>"NV", "New Hampshire"=>"NH", "New Mexico"=>"NM", "New Jersey"=>"NJ", "New York"=>"NY", "North Carolina"=>"NC", "North Dakota"=>"ND", "Ohio"=>"OH", "Oklahoma"=>"OK", "Oregon"=>"OR", "Pennsylvania"=>"PA", "Rhode Island"=>"RI", "South Carolina"=>"SC", "South Dakota"=>"SD", "Tennessee"=>"TN", "Texas"=>"TX", "Utah"=>"UT", "Vermont"=>"VT", "Virginia"=>"VA", "Washington"=>"WA", "West Virginia"=>"WV", "Wisconsin"=>"WI", "Wyoming"=>"WY");  ?>
<!-- CITY, STATE, ZIP -->		
	<dt><label for="city" class="more"><?=$this->lang->line('FAL_user_city_label')?></label>, <label for="state" class="more"><?=$this->lang->line('FAL_user_state_label')?></label>, <label for="zip" class="more"><?=$this->lang->line('FAL_user_zip_label')?></label></dt>
	<dd><?=form_input(array('name'=>'city', 
	                       'id'=>'city',
	                       'maxlength'=>'200',
						   'class'=>'medium',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'city'} : '')))?>

	<?= getState('state') ?>
	<?=form_input(array('name'=>'zip', 
	                       'id'=>'zip',
	                       'maxlength'=>'10',
						   'class'=>'small',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'zip'} : '')))?>
	<dd class="clear"><hr /></dd>

<!-- PHONE -->
	<dt><label for="phone"><?=$this->lang->line('FAL_user_phone_label')?></label></dt>
	<dd><?=form_input(array('name'=>'phone', 
	                       'id'=>'phone',
	                       'maxlength'=>'20',
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'phone'} : '')))?>
	<dd class="note">Format: <strong>555-555-1234</strong></dd>
	<dd class="clear"><hr /></dd>
		
<!-- AGENCY STATE AND LICENSE -->
	<dt><label for="agency_state_number" class="more">License Number</label> and <label for="agency_license_state" class="more">State</label></dt>
	<dd><?=form_input(array('name'=>'agency_state_number', 
	                       'id'=>'agency_state_number',
	                       'maxlength'=>'200',
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'agency_state_number'} : '')))?>
	<?= getState('agency_license_state') ?>
	<dd class="clear"><hr /></dd>

<!-- ADDITIONAL AGENCY STATES/LICENSE NUMBERS AND TERMS-->
	<dt><label for="more_agencies">Additional License Numbers and States</label></dt>
	<dd><textarea name="more_agencies" id="more_agencies" class="full"><?php echo $this->input->post('more_agencies'); ?></textarea></dd>
	<dd class="clear"><hr /></dd>

<!-- AGENCY INFORMATION -->
	<dt><label for="agency"><?=$this->lang->line('FAL_user_agency_label')?></label></dt>
	<dd>Are you affiliated with an agency or facility?</dd>
	<dd>
		<ul>
			<li><input name="agency" type="radio" id="yes" value="yes" class="radio" <?=isset($this->fal_validation) ? $this->fal_validation->set_radio('agency', 'yes') : ''?> /> <label for="yes">Yes</label> <span class="notice">requires you to complete additional agency fields below</span></li>
			<li><input name="agency" type="radio" id="no" value="no" class="radio" <?=isset($this->fal_validation) ? $this->fal_validation->set_radio('agency', 'no') : ''?> /> <label for="no">No</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

<!-- AGENCY AFFILIATION INFORMATION -->
	<dt><label for="agency_affiliation"><?=$this->lang->line('FAL_user_agency_affiliation_label')?></label></dt>
	<dd><?=form_input(array('name'=>'agency_affiliation', 
	                       'id'=>'agency_affiliation',
	                       'maxlength'=>'200',
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'agency_affiliation'} : '')))?>
	<dd class="clear"><hr /></dd>

<!-- AGENCY ADDRESS -->
	<dt><label for="agency_address"><?=$this->lang->line('FAL_user_agency_address_label')?></label></dt>
	<dd><?=form_input(array('name'=>'agency_address', 
	                       'id'=>'agency_address',
	                       'maxlength'=>'200',
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'agency_address'} : '')))?>
	<dd class="note">Format: <strong>1807 Hendricks Ave.</strong></dd>
	<dd class="clear"><hr /></dd>

<!-- AGENCY CITY, STATE, ZIP -->
	<dt><label for="agency_city" class="more"><?=$this->lang->line('FAL_user_agency_city_label')?></label>, <label for="agency_state" class="more"><?=$this->lang->line('FAL_user_agency_state_label')?></label>, <label for="agency_zip" class="more"><?=$this->lang->line('FAL_user_agency_zip_label')?></label></dt>
	<dd><?=form_input(array('name'=>'agency_city', 
	                       'id'=>'agency_city',
	                       'maxlength'=>'200',
						   'class'=>'medium',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'agency_city'} : '')))?>

	<?= getState('agency_state') ?>
	<?=form_input(array('name'=>'agency_zip', 
	                       'id'=>'agency_zip',
	                       'maxlength'=>'10',
						   'class'=>'small',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'agency_zip'} : '')))?>
	<dd class="clear"><hr /></dd>

<!-- AGENCY PHONE -->
	<dt><label for="agency_phone"><?=$this->lang->line('FAL_user_agency_phone_label')?></label></dt>
	<dd><?=form_input(array('name'=>'agency_phone', 
	                       'id'=>'agency_phone',
	                       'maxlength'=>'20',
						   'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'agency_phone'} : '')))?>
	<dd class="note">Format: <strong>555-555-1234</strong></dd>
	<dd class="clear"><hr /></dd>
		<dd><input name="terms_conditions" type="checkbox" id="terms_conditions" value="yes" <?= $this->fal_validation->set_checkbox('terms_conditions', 'yes'); ?> class="checkbox" /> <label for="terms_conditions"><span class="notice">I agree to AlphaNet's <a href="http://www.alphanet.org/terms-of-use/" target="_blank">terms of use</a> and <a href="http://www.alphanet.org/privacy-policy/" target="_blank">privacy policy</a></span></label></dd>

	<dd class="submit"><input type="image" src="/public/shared/images/button-submit.jpg" alt="Submit" value="Submit" name="register" id="submit" class="submit" /></dd>
</dl>

<?=form_close()?>

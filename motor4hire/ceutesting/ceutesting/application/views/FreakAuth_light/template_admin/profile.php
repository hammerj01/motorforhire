		<h2>Profile</h2>
		<?php if ($this->validation->error_string) { ?>
			<div class="message error">
				<ul><?=$this->validation->error_string; ?></ul>
			</div><!-- .message -->
		<?php } ?>
		
		<?php if (isset($confirmation_message)) { ?>
			<div class="message">
				<ul><li><?=$confirmation_message; ?></li></ul>
			</div><!-- .message -->
		<?php } ?>
		
		<div id="profile_status">
			<div id="test_wrapper">
				<div id="test_status">
					<h4>Test Status:</h4>
					<h2><?php echo $pass_fail_progress; ?></h2>
				</div>
				<div id="test_score">
					<h5>Test Score:</h5>
					<h2><?php echo $score; ?>%</h2>
				</div>
			</div> <!-- close #test_wrapper -->
			
			
			<?php if ($score >= 80) { ?>
				<?php if ($status == 'pass' && isAdmin()) { ?>
					<h3>Evaluation Incompete</h3>
					<p>This person still needs to complete their evaluation.</p>
				<?php } ?>
			
				<?php if ($status == 'pass' && !isAdmin()) { ?>
					<ul id="nav_sub" class="last">
						<li><?php echo anchor('dashboard/evaluation', 'Complete Evaluation'); ?></li>
					</ul>
				<?php } ?>

				<?php if ($status == 'complete') { ?>
					<ul id="nav_sub" class="last">
						<li><?php echo anchor('dashboard/printcertificate/'.$this->user_id, 'Print Certificate'); ?></li>
					<li><?php echo anchor('dashboard/evaluation/view/'.$this->user_id, 'View Evaluation'); ?></li>		
					</ul>
				<?php } ?>
			<?php } ?>

			<?php if ($score < 80 && $score != 0 && !isAdmin()) { ?>
			<ul id="nav_sub" class="last">
			<li><?php echo anchor('dashboard/prolastin/take_test_again', 'Take Test Again'); ?></li>
			</ul>
			<?php } ?>
			
			<?php if (!isAdmin()) { ?>
				<?php if ($status == 'page_one' OR $status == 'page_two' OR $status == 'page_three' OR $status == 'page_four') { ?>
					<ul id="nav_sub" class="last">
						<li><?php echo anchor('dashboard/prolastin', 'Resume Test'); ?></li>
					</ul>
				<?php } ?>
			<?php } ?>
			
			</div> <!-- close #profile_status -->
			<?php 
				$hidden = array('redisplay' => 'true');
				echo form_open('dashboard/profile/', '', $hidden);
			?>
			
				<dl class="two_column">
					<dt><label>Email</label></dt>
					<dd><strong><?php echo anchor('myaccount/edit/'.$this->user_id, 'Edit email address &raquo;'); ?></strong></dd>
					<dd class="clear"><hr /></dd>
					<dt><label>Password</label></dt>
					<dd><strong><?php echo anchor('myaccount/edit/'.$this->user_id, 'Edit password &raquo;'); ?></strong></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="first_name">First name</label></dt>
					<dd><input name="first_name" type="text" id="first_name" class="full" value="<?php if (isset($first_name)) { echo $first_name; } else { echo $this->validation->first_name; } ?>" /></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="last_name">Last name</label></dt>
					<dd><input name="last_name" type="text" id="last_name" class="full" value="<?php if (isset($last_name)) { echo $last_name; } else { echo $this->validation->last_name; } ?>" /></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="address">Address</label></dt>
					<dd><input name="address" type="text" id="address" class="full" value="<?php if (isset($address)) { echo $address; } else { echo $this->validation->address; } ?>" /></dd>
					<dd class="note">Format: <strong>1807 Hendricks Ave.</strong></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="city" class="more">City</label>, <label for="state" class="more">State</label>, <label for="zip">Zip</label></dt>
					<dd><input name="city" type="text" id="city" class="medium" value="<?php if (isset($city)) { echo $city; } else { echo $this->validation->city; } ?>" /> 
					<?php 
						if (isset($state)) 
						{ 
							$selected_state = $state; 
						} else { 
							$selected_state = $_POST['state']; 
						}
						echo getStateEdit('state', $selected_state) 
					?>

					<input name="zip" type="text" id="zip" class="small" value="<?php if (isset($zip)) { echo $zip; } else { echo $this->validation->zip; } ?>" /></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="phone">Phone</label></dt>
					<dd><input name="phone" type="text" id="phone" class="full" value="<?php if (isset($phone)) { echo $phone; } else { echo $this->validation->phone; } ?>" /></dd>
					<dd class="clear"><hr /></dd>
					
					<dt><label for="agency_state_number" class="more">License Number</label> and <label for="agency_license_state" class="more">State</label></dt>
					
					<dd>
					<input name="agency_state_number" type="text" id="agency_state_number" class="medium" value="<?php if (isset($agency_state_number)) { echo $agency_state_number; } else { echo $this->validation->agency_state_number; } ?>" />
					<?php 
						if (isset($agency_license_state)) 
						{ 
							$selected_state = $agency_license_state; 
						} else { 
							$selected_state = $_POST['agency_license_state']; 
						}
						echo getStateEdit('agency_license_state', $selected_state) 
					?>
					</dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="more_agencies">Additional License Numbers and States</label></dt>
					<dd><textarea name="more_agencies" id="more_agencies" class="full"><?php if (isset($more_agencies)) { echo $more_agencies; } else { echo $this->validation->more_agencies; } ?></textarea></dd>
					
					<dt><label for="agency">Agency</label></dt>
					<dd>Are you affiliated with an agency or facility?</dd>
					<dt></dt>
					<dd>
						<ul>
							<li><input name="agency" type="radio" id="yes" value="yes" class="radio" <?php if ($agency == 'yes') { echo 'checked'; } else { echo $this->validation->agency; } ?> /> <label for="yes">Yes</label> <span class="notice">requires you to complete additional agency fields below</span></li>
							<li><input name="agency" type="radio" id="no" value="no" class="radio" <?php if ($agency == 'no') { echo 'checked'; } else { echo $this->validation->agency; } ?> /> <label for="no">No</label></li>

						</ul>
					</dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="agency_affiliation">Agency/Facility Affiliation</label></dt>
					<dd><input name="agency_affiliation" type="text" id="agency_affiliation" class="full" value="<?php if (isset($agency_affiliation)) { echo $agency_affiliation; } else { echo $this->validation->agency_affiliation; } ?>" /></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="agency_address">Address</label></dt>
					<dd><input name="agency_address" type="text" id="agency_address" class="full" value="<?php if (isset($agency_address)) { echo $agency_address; } else { echo $this->validation->agency_address; } ?>" /></dd>

					<dd class="note">Format: <strong>1807 Hendricks Ave.</strong></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="agency_city" class="more">City</label>, <label for="agency_state" class="more">State</label>, <label for="agency_zip">Zip</label></dt>
					<dd><input name="agency_city" type="text" id="agency_city" class="medium" value="<?php if (isset($agency_city)) { echo $agency_city; } else { echo $this->validation->agency_city; } ?>" /> 
					<?php 
						if (isset($agency_state)) 
						{ 
							$selected_state = $agency_state; 
						} else { 
							$selected_state = $_POST['agency_state']; 
						}
						echo getStateEdit('agency_state', $selected_state) 
					?>
					<input name="agency_zip" type="text" id="agency_zip" class="small" value="<?php if (isset($agency_zip)) { echo $agency_zip; } else { echo $this->validation->agency_zip; } ?>" /></dd>
					<dd class="clear"><hr /></dd>
					<dt><label for="agency_phone">Phone</label></dt>
					<dd><input name="agency_phone" type="text" id="agency_phone" class="full" value="<?php if (isset($agency_phone)) { echo $agency_phone; } else { echo $this->validation->agency_phone; } ?>" /></dd>
					<dd class="clear"><hr /></dd>

					<dd class="submit"><input type="image" src="/public/shared/images/button-update.jpg" alt="Update Profile" name="update_profile" id="update_profile" /></dd>
				</dl>
			</form>
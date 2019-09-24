<h2><?=$action?></h2>
<?php if ($this->fal_validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->fal_validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>
<?=form_open('dashboard/admins/add')?>
	<dl class="two_column">
		<dt><label for="user_name">Username</label></dt>
		<dd>
			<?=form_hidden('id', 0);?>
			<?=form_input(array('name'=>'user_name', 
	                       'id'=>'user_name',
	                       'maxlength'=>'45', 
	                       'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'user_name'} : '')))?>
		</dd>
		<dd class="clear"><hr /></dd>
		
		<dt><label for="email">Email</label></dt>
		<dd>
			<?=form_input(array('name'=>'email', 
	                       'id'=>'email',
	                       'maxlength'=>'120', 
	                       'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'email'} : '')))?>
		</dd>
		<dd class="clear"><hr /></dd>
		
		<dt><label for="password">Password</label></dt>
		<dd>
			<?=form_password(array('name'=>'password', 
	                       'id'=>'password',
	                       'maxlength'=>'16', 
	                       'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'password'} : '')))?>
		</dd>
		<dd class="clear"><hr /></dd>
		
		<dt><label for="password_confirm">Confirm Password</label></dt>
		<dd>
			<?=form_password(array('name'=>'password_confirm', 
	                       'id'=>'password_confirm',
	                       'maxlength'=>'16', 
	                       'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'password_confirm'} : '')))?>
		</dd>
		<dd class="clear"><hr /></dd>
		
		<dt><label for="role">Role</label></dt>
		<dd>
			<select name="role" id="role">
         	<option value="">-------------</option>
	       	<?php foreach ($role_options as $value)
	       	{?>
	       		<option value="<?=$value?>" <?=$this->fal_validation->set_select('role', $value)?>><?=$value?></option>
	       	<?php 
	       	}
	       	?>
	       	</select>
		</dd>
		<dd class="clear"><hr /></dd>
		
		<dt><label for="banned">Is Banned?</label></dt>
		<dd><?=form_checkbox('banned', 1, FALSE)?></dd>
		<dd class="submit"><input type="image" src="/public/shared/images/button-submit.jpg" alt="Submit" value="Submit" name="submit" id="submit" class="submit" /></dd>
	</dl>
</form>
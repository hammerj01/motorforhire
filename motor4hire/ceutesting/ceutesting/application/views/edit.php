<h2>Profile: Edit Email and Password</h2>

<?php if ($this->validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>
		
<?=form_open('/myaccount/edit/'.$user['id'])?>
	<dl class="two_column">
		<dt><label for="email">Email</label></dt>
		<dd>
			<?=form_input(array('name'=>'email', 
	                       'id'=>'email',
	                       'maxlength'=>'120', 
	                       'class'=>'full',
	                       'value'=>(isset($user['email']) ? $user['email'] : $this->validation->{'email'})))?>
		</dd>
		<dd class="clear"><hr /></dd>
		<dt><label for="password">Password</label></dt>
		<dd>
			<?=form_password(array('name'=>'password', 
	                       'id'=>'password',
	                       'maxlength'=>'16', 
	                       'class'=>'full',
	                       'value'=>(isset($this->validation->{'password'}) ? $this->validation->{'password'} : '')))?>
		</dd>
		<dd class="clear"><hr /></dd>
		<dt><label for="password_confirm">Confirm Password</label></dt>
		<dd>
			<?=form_password(array('name'=>'password_confirm', 
	                       'id'=>'password_confirm',
	                       'maxlength'=>'16', 
	                       'class'=>'full',
	                       'value'=>(isset($this->validation) ? $this->validation->{'password_confirm'} : '')))?>
		</dd>
		<dd><input type="image" src="/public/shared/images/button-submit.jpg" alt="Submit" value="Submit" name="submit" id="submit" class="submit" /></dd>
	</dl>
</form>
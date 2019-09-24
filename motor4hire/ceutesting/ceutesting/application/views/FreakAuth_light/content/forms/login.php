<h2><?=$heading?></h2>
<?php if ($this->fal_validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->fal_validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>
<?php if (isset($this->fal_validation->login_error_message)) { ?>
	<div class="message error">
		<ul><li><?=$this->fal_validation->login_error_message; ?></li></ul>
	</div><!-- .message -->
<?php } ?>

<p>You must <?=anchor($this->config->item('FAL_register_uri'), 'Register for this program')?> before you can login. Login to resume or retake your test, complete your evaluation and print your certificate.</p>
<p><span class="notice">* All fields are required</span></p>

<?=form_open($this->uri->uri_string(), array('id' => 'login_form'))?>
<dl class="two_column">
	<dt><label for="user_name"><?=$this->lang->line('FAL_user_name_label')?>:</label></dt>
	<dd><?=form_input(array('name'=>'user_name', 
	                       'id'=>'user_name',
	                       'maxlength'=>'30', 
	                       'size'=>'30',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'user_name'} : '')))?>
    </dd>
	<dd class="clear"><hr /></dd>
    
<dt><label for="password"><?=$this->lang->line('FAL_user_password_label')?>:</label></dt>
<dd><?=form_password(array('name'=>'password', 
	                       'id'=>'password',
	                       'maxlength'=>'30', 
	                       'size'=>'30',
	                       'value'=>''))?>
 	<?=anchor($this->config->item('FAL_forgottenPassword_uri'), $this->lang->line('FAL_forgotten_password_label'), array('class' => 'note'))?>
	</dd>
	<dd class="clear"><hr /></dd>
	<dd class="submit remember">
	 	<input type="image" src="/public/shared/images/button-login2.jpg" alt="Login" value="Login" name="login" id="login" class="submit" />
	<!-- <input name="remember" id="remember" type="checkbox" value="remember" checked="checked" /> <label for="remember" class="remember">Remember Me</label>--></dd> 
</dl>
<?=form_close()?>
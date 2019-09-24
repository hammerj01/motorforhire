<h2><?=$heading?></h2>
<?php if ($this->fal_validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->fal_validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>

<?=form_open($this->uri->uri_string(), array('id' => 'change_password_form'))?>
<dl class="two_column">
<!-- USERNAME -->
	<dt><label for="user_name"><?=$this->lang->line('FAL_user_name_label');?></label></dt>
	<dd><?=form_input(array('name'=>'user_name', 
	                       'id'=>'user_name',
	                       'maxlength'=>'30', 
	                       'class'=>'full',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'user_name'} : '')))?>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="password"><?=$this->lang->line('FAL_old_password_label');?></label></dt>
	<dd><?=form_password(array('name'=>'old_password', 
	                       'id'=>'old_password',
	                       'maxlength'=>'16', 
	                       'class'=>'full',
	                       'value'=>''))?>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="new_password"><?=$this->lang->line('FAL_new_password_label');?>:</label></dt>
	<dd><?=form_password(array('name'=>'password', 
	                       'id'=>'password',
	                       'maxlength'=>'16', 
	                       'class'=>'full',
	                       'value'=>''))?>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="password_confirm"><?=$this->lang->line('FAL_retype_new_password_label');?>:</label></dt>
	<dd><?=form_password(array('name'=>'password_confirm', 
	                       'id'=>'password_confirm',
	                       'maxlength'=>'16', 
	                       'class'=>'full',
	                       'value'=>''))?>	
	</dd>
	<dd class="clear"><hr /></dd>
		
	<dd class="submit"><input type="submit" name="Submit" value="<?=$this->lang->line('FAL_submit')?>" class="submit"/></dd>
</dl>
<?=form_close()?>
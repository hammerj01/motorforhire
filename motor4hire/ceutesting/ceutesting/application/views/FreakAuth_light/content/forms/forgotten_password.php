<h2><?=$heading?></h2>
<?php if ($this->fal_validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->fal_validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>

<?=form_open($this->uri->uri_string(), array('id' => 'forgotten_password_form'))?>
<dl class="two_column">
<!-- EMAIL -->
	<dt><label for="email"><?=$this->lang->line('FAL_user_email_label')?></label></dt>
	<dd><?=form_input(array('name'=>'email', 
	                       'id'=>'email',
	                       'maxlength'=>'100', 
	                       'size'=>'60',
	                       'value'=>(isset($this->fal_validation) ? $this->fal_validation->{'email'} : '')))?>
    </dd>
	<dd class="clear"><hr /></dd>
	
	<dd class="submit"><?=form_submit(array('name'=>'submit', 'value'=>$this->lang->line('FAL_submit')))?></dd>
</dl>
<?=form_close()?>
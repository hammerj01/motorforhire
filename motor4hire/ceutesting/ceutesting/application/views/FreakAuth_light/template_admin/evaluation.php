<h2>Evaluation</h2>
<?php if ($status != 'pass') { ?>

<div class="message error">
<ul>
	<li>You must pass the test before you take the evaluation. Please <?php echo anchor('dashboard/prolastin', 'finish the test') ?>.</li>
</ul>
</div><!-- .message -->

<?php } else { ?>	

<?php if ($this->validation->error_string) { ?>
<div class="message error">
<ul>
	<li><strong>Please answer all questions</strong></li>
	<?=$this->validation->error_string; ?>
</ul>
</div><!-- .message -->
<?php } ?>

<div class="callout">
<p><em>Use the following rating scale to answer the questions below:</em></p>
<ul id="rating_scale">
<li><strong>4</strong> = Excellent</li>
<li><strong>3</strong> = Average</li>
<li><strong>2</strong> = Fair</li>
<li><strong>1</strong> = Poor</li>
<li><strong>N</strong> = Not Applicable</li>
</ul>

</div>

<?php echo form_open('dashboard/evaluation/');?>
<p><strong>To what extent have you achieved each of the objectives below?</strong></p>
<dl class="two_column">
	<dt><input name="q1" type="text" id="q1" class="small" maxlength="1" tabindex="1" value="<?php echo $this->validation->q1; ?>" /></dt>
	<dd><label for="q1">1. Participants will discover that Alpha-1 is genetically transmitted, can lead to liver disease, early onset emphysema, and other conditions.</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q2" type="text" id="q2" class="small" maxlength="1" tabindex="2" value="<?php echo $this->validation->q2; ?>" /></dt>
	<dd><label for="q2">2. Participants will recognize that the disorder has been generally under diagnosed and/or misdiagnosed.</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q3" type="text" id="q3" class="small" maxlength="1" tabindex="3" value="<?php echo $this->validation->q3; ?>" /></dt>
	<dd><label for="q3">3. Participants will list at least three key elements in the treatment plan of individuals with Alpha-1 including augmentation therapy with Prolastin-C.</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q4" type="text" id="q4" class="small" maxlength="1" tabindex="4" value="<?php echo $this->validation->q4; ?>" /></dt>
	<dd><label for="q4">4. Participants will indicate their specific knowledge of the criteria for initiating, dosing, and administering augmentation therapy with Prolastin-C.</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q5" type="text" id="q5" class="small" maxlength="1" tabindex="5" value="<?php echo $this->validation->q5; ?>" /></dt>
	<dd><label for="q5">5. Participants will list at least four potential side effects associated with augmentation therapy with Prolastin-C.</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q6" type="text" id="q6" class="small" maxlength="1" tabindex="6" value="<?php echo $this->validation->q6; ?>" /></dt>
	<dd><label for="q6">6. Each participant shall identify procedures for safe and appropriate handling of Prolastin-C, as well as parameters for patient assessment and monitoring during therapy.</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q7" type="text" id="q7" class="small" maxlength="1" tabindex="7" value="<?php echo $this->validation->q7; ?>" /></dt>
	<dd><label for="q7">7. Participants will name resources available in the community for those affected by Alpha-1 Antitrypsin Deficiency and their health care providers.</label></dd>
	<dd class="clear"><hr /></dd>
</dl>
<p><strong>General Questions (Use the scale above)</strong></p>
<dl class="two_column">
	<dt><input name="q8" type="text" id="q8" class="small" maxlength="1" tabindex="8" value="<?php echo $this->validation->q8; ?>" /></dt>
	<dd><label for="q8">8. To what extent did this program demonstrate effective teaching strategies?</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q9" type="text" id="q9" class="small" maxlength="1" tabindex="9" value="<?php echo $this->validation->q9; ?>" /></dt>
	<dd><label for="q9">9. To what extent was the overall  program goal met:  To increase  knowledge of Alpha-1 Antitrypsin Deficiency and Augmentation therapy.</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q10" type="text" id="q10" class="small" maxlength="1" tabindex="10" value="<?php echo $this->validation->q10; ?>" /></dt>
	<dd><label for="q10">10. At what level would you rate your knowledge of this subject before viewing this program?</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q11" type="text" id="q11" class="small" maxlength="1" tabindex="11" value="<?php echo $this->validation->q11; ?>" /></dt>
	<dd><label for="q11">11. At what level would you rate your knowledge of this subject after viewing this program?</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><input name="q12" type="text" id="q12" class="small" maxlength="1" tabindex="12" value="<?php echo $this->validation->q12; ?>" /></dt>
	<dd><label for="q12">12. How many hours did it take you to complete this activity?</label></dd>
	<dd class="clear"><hr /></dd>
	<dt><label>13. Was this program free of commercial bias?</label></dt>
	<dd>
		<ul>
			<li><input name="q13" type="radio" id="yes" class="radio" tabindex="13" value="yes" <?= $this->validation->set_radio('q13', 'yes'); ?> /> <label for="yes">Yes</label></li>
			<li><input name="q13" type="radio" id="no" class="radio" tabindex="14" value="no" <?= $this->validation->set_radio('q13', 'no'); ?> /> <label for="no">No</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	<dt><label for="q14">14. If No, explain</label></dt>

	<dd><textarea name="q14" id="q14" class="full" tabindex="15"><?php echo $this->validation->q14; ?></textarea></dd>
	<dd class="clear"><hr /></dd>
	<dt><label for="q15">15. Comments for Improvements</label></dt>
	<dd><textarea name="q15" id="q15" class="full" tabindex="16"><?php echo $this->input->post('q15'); ?></textarea></dd>
	<dd class="clear"><hr /></dd>
	<dd class="submit"><input type="image" src="/public/shared/images/button-submit.jpg" alt="Submit"  tabindex="17" /></dd>
</dl>

</form>
<?php } ?>
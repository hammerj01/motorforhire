<h3>Step 2 of 4</h3>
<h2>Alpha-1 Antitrypsin Deficiency and Augmentation Therapy-Prolastin</h2>		

<?php if ($this->validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>

<?php echo form_open('dashboard/prolastin/page_two/');?>
	<dl class="one_column">
	<dt></dt>
	<dd><span class="notice">Test progress is saved at the end of each step so you can take the test at your own pace.</span></dd>
	<dd class="clear"><hr /></dd>
	<dt><label for="single_select">11. A contraindication for augmentation therapy is?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q1" id="q1_1" value="a" class="radio" tabindex="1" <?php if ($answer01 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'a'); } ?> /> 
			<label for="q1_1">Known IgA deficiency.</label></li> 
			<li><input type="radio" name="q1" id="q1_2" value="b" class="radio" tabindex="2" <?php if ($answer01 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'b'); } ?> />
			<label for="q1_2">Penicillin allergy.</label></li>
			<li><input type="radio" name="q1" id="q1_3" value="c" class="radio" tabindex="3" <?php if ($answer01 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'c'); } ?> />
			<label for="q1_3">Known IgE deficiency.</label></li>
			<li><input type="radio" name="q1" id="q1_4" value="d" class="radio" tabindex="4" <?php if ($answer01 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'd'); } ?> />
			<label for="q1_4">Egg allergy.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">12. Which of the following is the recommended dose of Prolastin-C?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q2" id="q2_1" value="a" class="radio" tabindex="5" <?php if ($answer02 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'a'); } ?> /> 
			<label for="q2_1">80 mg/kg actual body weight once weekly.</label></li> 
			<li><input type="radio" name="q2" id="q2_2" value="b" class="radio" tabindex="6" <?php if ($answer02 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'b'); } ?> /> 
			<label for="q2_2">60 mg/kg actual body weight once weekly.</label></li>
			<li><input type="radio" name="q2" id="q2_3" value="c" class="radio" tabindex="7" <?php if ($answer02 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'c'); } ?> /> 
			<label for="q2_3">120 mg/kg actual body weight once weekly.</label></li>
			<li><input type="radio" name="q2" id="q2_4" value="d" class="radio" tabindex="8" <?php if ($answer02 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'd'); } ?> /> 
			<label for="q2_4">60 mg/kg actual body weight bi-weekly.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">13. Alpha-1 patients are often misdiagnosed for which of the following reasons?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q3" id="q3_1" value="a" class="radio" tabindex="9" <?php if ($answer03 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'a'); } ?> />  
			<label for="q3_1">The usual presenting symptom of Alpha-1 lung disease is dyspnea on exertion.</label></li> 
			<li><input type="radio" name="q3" id="q3_2" value="b" class="radio" tabindex="10" <?php if ($answer03 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'b'); } ?> />
			<label for="q3_2">In existing COPD or asthma patients, the diagnosis of Alpha-1 is not thought of.</label></li>
			<li><input type="radio" name="q3" id="q3_3" value="c" class="radio" tabindex="11" <?php if ($answer03 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'c'); } ?> />
			<label for="q3_3">Patients with liver cirrhosis are usually suspected of alcohol abuse.</label></li>
			<li><input type="radio" name="q3" id="q3_4" value="d" class="radio" tabindex="12" <?php if ($answer03 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'd'); } ?> />
			<label for="q3_4">All of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">14. A yearly flu vaccination and the pneumonia vaccine every 5-7 years are recommended for patients with Alpha-1.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q4" id="q4_1" value="a" class="radio" tabindex="13" <?php if ($answer04 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'a'); } ?> /> 
			<label for="q4_1">True.</label></li> 
			<li><input type="radio" name="q4" id="q4_2" value="b" class="radio" tabindex="14" <?php if ($answer04 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'b'); } ?> />
			<label for="q4_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">15. Treatment planning for patients with Alpha-1 lung disease may include which of the following?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q5" id="q5_1" value="a" class="radio" tabindex="15" <?php if ($answer05 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'a'); } ?> /> 
			<label for="q5_1">Genetic counseling.</label></li> 
			<li><input type="radio" name="q5" id="q5_2" value="b" class="radio" tabindex="16" <?php if ($answer05 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'b'); } ?> />
			<label for="q5_2">Smoking cessation.</label></li>
			<li><input type="radio" name="q5" id="q5_3" value="c" class="radio" tabindex="17" <?php if ($answer05 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'c'); } ?> />
			<label for="q5_3">Pulmonary Rehabilitation.</label></li>
			<li><input type="radio" name="q5" id="q5_4" value="d" class="radio" tabindex="18" <?php if ($answer05 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'd'); } ?> />
			<label for="q5_4">All of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">16. The products of cigarette combustion are especially destructive to persons with Alpha-1 lung disease for two important reasons, these are:</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q6" id="q6_1" value="a" class="radio" tabindex="21" <?php if ($answer06 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'a'); } ?> /> 
			<label for="q6_1">Smoking leads to severe halitosis.</label></li> 
			<li><input type="radio" name="q6" id="q6_2" value="b" class="radio" tabindex="22" <?php if ($answer06 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'b'); } ?> />
			<label for="q6_2">Smoke inactivates the alpha-1 antitrypsin in the lungs.</label></li>
			<li><input type="radio" name="q6" id="q6_3" value="c" class="radio" tabindex="23" <?php if ($answer06 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'c'); } ?> /> 
			<label for="q6_3">Smoking attracts white blood cells to the lungs in large numbers.</label></li> 
			<li><input type="radio" name="q6" id="q6_4" value="d" class="radio" tabindex="24" <?php if ($answer06 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'd'); } ?> />
			<label for="q6_4">B and C only.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">17. Normal levels of alpha-1 antitrypsin may be expressed by two different scales; the micromolar (&micro;M) scale or the milligram per deciliter (mg/dL) scale. Which of the following is a correct value?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q7" id="q7_1" value="a" class="radio" tabindex="25" <?php if ($answer07 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'a'); } ?> /> 
			<label for="q7_1">25-40 mg/dL.</label></li> 
			<li><input type="radio" name="q7" id="q7_2" value="b" class="radio" tabindex="26" <?php if ($answer07 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'b'); } ?> />
			<label for="q7_2">125-400 &micro;M.</label></li>
			<li><input type="radio" name="q7" id="q7_3" value="c" class="radio" tabindex="27" <?php if ($answer07 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'c'); } ?> />
			<label for="q7_3">.05-3.0 mg/dL.</label></li>
			<li><input type="radio" name="q7" id="q7_4" value="d" class="radio" tabindex="28" <?php if ($answer07 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'd'); } ?> />
			<label for="q7_4">25-40 &micro;M.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">18. Severe Alpha-1 deficiency is generally identified at what levels? </label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q8" id="q8_1" value="a" class="radio" tabindex="29" <?php if ($answer08 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'a'); } ?> /> 
			<label for="q8_1">Less than 11 &micro;M or less than 60-80 mg/dL.</label></li> 
			<li><input type="radio" name="q8" id="q8_2" value="b" class="radio" tabindex="30" <?php if ($answer08 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'b'); } ?> />
			<label for="q8_2">Less than 60-80 &micro;M or less than 11 mg/dL.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">19. Alpha-1 is the number one genetic cause of which organ transplant in children?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q9" id="q9_1" value="a" class="radio" tabindex="33" <?php if ($answer09 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'a'); } ?> /> 
			<label for="q9_1">Lung.</label></li> 
			<li><input type="radio" name="q9" id="q9_2" value="b" class="radio" tabindex="34" <?php if ($answer09 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'b'); } ?> />
			<label for="q9_2">Liver.</label></li>
			<li><input type="radio" name="q9" id="q9_3" value="c" class="radio" tabindex="35" <?php if ($answer09 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'c'); } ?> />
			<label for="q9_3">Heart.</label></li>
			<li><input type="radio" name="q9" id="q9_4" value="d" class="radio" tabindex="36" <?php if ($answer09 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'd'); } ?> />
			<label for="q9_4">Kidney.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">20. Unreconstituted Prolastin-C may be stored</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q10" id="q10_1" value="a" class="radio" tabindex="37" <?php if ($answer10 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'a'); } ?> /> 
			<label for="q10_1">In the freezer.</label></li> 
			<li><input type="radio" name="q10" id="q10_2" value="b" class="radio" tabindex="38" <?php if ($answer10 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'b'); } ?> />
			<label for="q10_2">At room temperature-not to exceed 77&deg; F.</label></li>
			<li><input type="radio" name="q10" id="q10_3" value="c" class="radio" tabindex="39" <?php if ($answer10 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'c'); } ?> />
			<label for="q10_3">Refrigerated at 2-8&deg; C; 36-46&deg; F.</label></li>
			<li><input type="radio" name="q10" id="q10_4" value="d" class="radio" tabindex="40" <?php if ($answer10 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'd'); } ?> />
			<label for="q10_4">B and C only.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dd class="submit"><input type="image" src="/public/shared/images/button-next.jpg" alt="Next Step" name="next_step" id="next_step" value="next_step" tabindex="41" /></dd>
	</dl>
</form>
<h3>Step 1 of 4</h3>
<h2>Alpha-1 Antitrypsin Deficiency and Augmentation Therapy-Prolastin</h2>

<?php if ($this->validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>

<?php echo form_open('dashboard/prolastin/');?>
	<dl class="one_column">
	<dt></dt>
	<dd><span class="notice">Test progress is saved at the end of each step so you can take the test at your own pace.</span></dd>
	<dd class="clear"><hr /></dd>
	<dt><label for="single_select">1. Persons with Alpha-1 are at high risk for developing life-threatening liver disease for which of the following reasons?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q1" id="q1_1" value="a" class="radio" tabindex="1" <?php if ($answer01 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'a'); } ?> /> 
			<label for="q1_1">The alpha-1 antitrypsin produced by the liver in individuals with Alpha-1 is abnormal.</label></li> 
			<li><input type="radio" name="q1" id="q1_2" value="b" class="radio" tabindex="2" <?php if ($answer01 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'b'); } ?> />
			<label for="q1_2">The alpha-1 antitrypsin produced by the liver in individuals with Alpha-1 is poorly secreted, resulting in an accumulation within the liver and a marked reduction in circulating alpha-1 antitrypsin protein.</label></li>
			<li><input type="radio" name="q1" id="q1_3" value="c" class="radio" tabindex="3" <?php if ($answer01 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'c'); } ?> />
			<label for="q1_3">A and B.</label></li>
			<li><input type="radio" name="q1" id="q1_4" value="d" class="radio" tabindex="4" <?php if ($answer01 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'd'); } ?> />
			<label for="q1_4">None of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">2. Persons with Alpha-1 are at high risk for developing life-threatening lung disease for which of the following reasons?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q2" id="q2_1" value="a" class="radio" tabindex="5" <?php if ($answer02 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'a'); } ?> /> 
			<label for="q2_1">Low levels of alpha-1 antitrypsin in the lungs allows for the destructive effects of neutrophil elastase to go unchecked resulting in damage to the alveoli and eventually leading to emphysema.</label></li> 
			<li><input type="radio" name="q2" id="q2_2" value="b" class="radio" tabindex="6" <?php if ($answer02 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'b'); } ?> /> 
			<label for="q2_2">Accumulation of alpha-1 antitrypsin protein in the lungs damages the gas exchange system of the lungs, the alveoli, and progressively leads to emphysema.</label></li>
			<li><input type="radio" name="q2" id="q2_3" value="c" class="radio" tabindex="7" <?php if ($answer02 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'c'); } ?> /> 
			<label for="q2_3">A and B.</label></li>
			<li><input type="radio" name="q2" id="q2_4" value="d" class="radio" tabindex="8" <?php if ($answer02 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'd'); } ?> /> 
			<label for="q2_4">None of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">3. The greatest single risk factor for Alpha-1 is?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q3" id="q3_1" value="a" class="radio" tabindex="9" <?php if ($answer03 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'a'); } ?> />  
			<label for="q3_1">A positive family history.</label></li> 
			<li><input type="radio" name="q3" id="q3_2" value="b" class="radio" tabindex="10" <?php if ($answer03 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'b'); } ?> />
			<label for="q3_2">Smoking.</label></li>
			<li><input type="radio" name="q3" id="q3_3" value="c" class="radio" tabindex="11" <?php if ($answer03 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'c'); } ?> />
			<label for="q3_3">Asbestos exposure.</label></li>
			<li><input type="radio" name="q3" id="q3_4" value="d" class="radio" tabindex="12" <?php if ($answer03 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'd'); } ?> />
			<label for="q3_4">Alcohol abuse.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">4. Alpha-1 is a genetic disorder in which an abnormal gene is inherited from each parent.  Which of the following combinations indicates the four most common genes for Alpha-1?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q4" id="q4_1" value="a" class="radio" tabindex="13" <?php if ($answer04 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'a'); } ?> /> 
			<label for="q4_1">M, S, Z and Null.</label></li> 
			<li><input type="radio" name="q4" id="q4_2" value="b" class="radio" tabindex="14" <?php if ($answer04 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'b'); } ?> />
			<label for="q4_2">A, B, D and Null.</label></li>
			<li><input type="radio" name="q4" id="q4_3" value="c" class="radio" tabindex="15" <?php if ($answer04 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'c'); } ?> />
			<label for="q4_3">Alpha, Beta, Zeta and Null.</label></li>
			<li><input type="radio" name="q4" id="q4_4" value="d" class="radio" tabindex="16" <?php if ($answer04 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'd'); } ?> />
			<label for="q4_4">None of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">5. Alpha-1 patients are classified as severely deficient when they have which combination of genes?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q5" id="q5_1" value="a" class="radio" tabindex="17" <?php if ($answer05 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'a'); } ?> /> 
			<label for="q5_1">ZZ.</label></li> 
			<li><input type="radio" name="q5" id="q5_2" value="b" class="radio" tabindex="18" <?php if ($answer05 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'b'); } ?> />
			<label for="q5_2">NullNull.</label></li>
			<li><input type="radio" name="q5" id="q5_3" value="c" class="radio" tabindex="19" <?php if ($answer05 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'c'); } ?> />
			<label for="q5_3">ZNull.</label></li>
			<li><input type="radio" name="q5" id="q5_4" value="d" class="radio" tabindex="20" <?php if ($answer05 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'd'); } ?> />
			<label for="q5_4">All of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">6. Lung transplantation is a cure for Alpha-1 Antitrypsin Deficiency.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q6" id="q6_1" value="a" class="radio" tabindex="21" <?php if ($answer06 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'a'); } ?> /> 
			<label for="q6_1">True.</label></li> 
			<li><input type="radio" name="q6" id="q6_2" value="b" class="radio" tabindex="22" <?php if ($answer06 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'b'); } ?> />
			<label for="q6_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">7. The World Health Organization recommends that all adults with which of the following medical conditions be tested for Alpha-1?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q7" id="q7_1" value="a" class="radio" tabindex="23" <?php if ($answer07 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'a'); } ?> /> 
			<label for="q7_1">COPD and/or Chronic Asthma.</label></li> 
			<li><input type="radio" name="q7" id="q7_2" value="b" class="radio" tabindex="24" <?php if ($answer07 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'b'); } ?> />
			<label for="q7_2">Family history of Alpha-1.</label></li>
			<li><input type="radio" name="q7" id="q7_3" value="c" class="radio" tabindex="25" <?php if ($answer07 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'c'); } ?> />
			<label for="q7_3">Chronic liver disease.</label></li>
			<li><input type="radio" name="q7" id="q7_4" value="d" class="radio" tabindex="26" <?php if ($answer07 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'd'); } ?> />
			<label for="q7_4">All of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">8. Which of the following are definitive diagnostic tests for Alpha-1?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q8" id="q8_1" value="a" class="radio" tabindex="27" <?php if ($answer08 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'a'); } ?> /> 
			<label for="q8_1">Phenotyping, Genotyping, Serum level.</label></li> 
			<li><input type="radio" name="q8" id="q8_2" value="b" class="radio" tabindex="28" <?php if ($answer08 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'b'); } ?> />
			<label for="q8_2">Chest X-ray, CT Scan, Pulmonary Function Tests.</label></li>
			<li><input type="radio" name="q8" id="q8_3" value="c" class="radio" tabindex="29" <?php if ($answer08 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'c'); } ?> />
			<label for="q8_3">All of the above.</label></li>
			<li><input type="radio" name="q8" id="q8_4" value="d" class="radio" tabindex="30" <?php if ($answer08 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'd'); } ?> />
			<label for="q8_4">None of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">9. Which medication noted below, is an FDA approved treatment specifically for Alpha-1 lung disease?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q9" id="q9_1" value="a" class="radio" tabindex="31" <?php if ($answer09 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'a'); } ?> /> 
			<label for="q9_1">Serevent.</label></li> 
			<li><input type="radio" name="q9" id="q9_2" value="b" class="radio" tabindex="32" <?php if ($answer09 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'b'); } ?> />
			<label for="q9_2">Albumin.</label></li>
			<li><input type="radio" name="q9" id="q9_3" value="c" class="radio" tabindex="33" <?php if ($answer09 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'c'); } ?> />
			<label for="q9_3">Progesterone.</label></li>
			<li><input type="radio" name="q9" id="q9_4" value="d" class="radio" tabindex="34" <?php if ($answer09 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'd'); } ?> />
			<label for="q9_4">Prolastin-C.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">10. The criteria for the initiation of Augmentation Therapy include which of the following?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q10" id="q10_1" value="a" class="radio" tabindex="35" <?php if ($answer10 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'a'); } ?> /> 
			<label for="q10_1">Patient must be under the care of a licensed physician familiar with the treatment.</label></li> 
			<li><input type="radio" name="q10" id="q10_2" value="b" class="radio" tabindex="36" <?php if ($answer10 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'b'); } ?> />
			<label for="q10_2">Patient should be evaluated for IgA deficiency.</label></li>
			<li><input type="radio" name="q10" id="q10_3" value="c" class="radio" tabindex="37" <?php if ($answer10 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'c'); } ?> />
			<label for="q10_3">Epinephrine should be available at initiation of therapy.</label></li>
			<li><input type="radio" name="q10" id="q10_4" value="d" class="radio" tabindex="38" <?php if ($answer10 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'd'); } ?> />
			<label for="q10_4">All of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dd class="submit"><input type="image" src="/public/shared/images/button-next.jpg" alt="Next Step" name="next_step" id="next_step" value="next_step" tabindex="40" /></form></dd>
	</dl>

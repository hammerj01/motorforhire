<h3>Step 4 of 4</h3>
<h2>Alpha-1 Antitrypsin Deficiency and Augmentation Therapy-Prolastin</h2>		

<?php if ($this->validation->error_string) { ?>
	<div class="message error">
		<ul><?=$this->validation->error_string; ?></ul>
	</div><!-- .message -->
<?php } ?>

<?php echo form_open('dashboard/prolastin/page_four/');?>
	<dl class="one_column">
	<dt></dt>
	<dd><span class="notice">Test progress is saved at the end of each step so you can take the test at your own pace.</span></dd>
	<dd class="clear"><hr /></dd>
	<dt><label for="single_select">31. All equipment used in the process of mixing and pooling Prolastin-C should be discarded in the household trash.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q1" id="q1_1" value="a" class="radio" tabindex="1" <?php if ($answer01 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'a'); } ?> /> 
			<label for="q1_1">True.</label></li> 
			<li><input type="radio" name="q1" id="q1_2" value="b" class="radio" tabindex="2" <?php if ($answer01 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q1', 'b'); } ?> />
			<label for="q1_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">32. Prolastin-C, once reconstituted appears:</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q2" id="q2_1" value="a" class="radio" tabindex="5" <?php if ($answer02 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'a'); } ?> /> 
			<label for="q2_1">Red tinged in solution.</label></li> 
			<li><input type="radio" name="q2" id="q2_2" value="b" class="radio" tabindex="6" <?php if ($answer02 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'b'); } ?> /> 
			<label for="q2_2">Clear to straw colored.</label></li>
			<li><input type="radio" name="q2" id="q2_3" value="c" class="radio" tabindex="7" <?php if ($answer02 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'c'); } ?> /> 
			<label for="q2_3">Dark amber.</label></li> 
			<li><input type="radio" name="q2" id="q2_4" value="d" class="radio" tabindex="8" <?php if ($answer02 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q2', 'd'); } ?> /> 
			<label for="q2_4">Cloudy.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">33. It is expected that particulates will be seen in completely reconstituted Prolastin-C.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q3" id="q3_1" value="a" class="radio" tabindex="9" <?php if ($answer03 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'a'); } ?> />  
			<label for="q3_1">True.</label></li> 
			<li><input type="radio" name="q3" id="q3_2" value="b" class="radio" tabindex="10" <?php if ($answer03 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q3', 'b'); } ?> />
			<label for="q3_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">34. Alpha-1 Antitrypsin Deficiency was first recognized in the early 1960's by?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q4" id="q4_1" value="a" class="radio" tabindex="13" <?php if ($answer04 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'a'); } ?> /> 
			<label for="q4_1">Professors Laurel and Hardy.</label></li> 
			<li><input type="radio" name="q4" id="q4_2" value="b" class="radio" tabindex="14" <?php if ($answer04 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'b'); } ?> />
			<label for="q4_2">Dr. Smith and Will Robinson.</label></li>
			<li><input type="radio" name="q4" id="q4_3" value="c" class="radio" tabindex="15" <?php if ($answer04 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'c'); } ?> /> 
			<label for="q4_3">Professor Carl-Bertil Laurell and Dr. Sten Eriksson.</label></li> 
			<li><input type="radio" name="q4" id="q4_4" value="d" class="radio" tabindex="16" <?php if ($answer04 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q4', 'd'); } ?> />
			<label for="q4_4">Dr. David Livinstone.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">35. Alpha-1 Antitrypsin Deficiency as common as which other genetic disorder?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q5" id="q5_1" value="a" class="radio" tabindex="17" <?php if ($answer05 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'a'); } ?> /> 
			<label for="q5_1">Gaucher's Disease.</label></li> 
			<li><input type="radio" name="q5" id="q5_2" value="b" class="radio" tabindex="18" <?php if ($answer05 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'b'); } ?> />
			<label for="q5_2">Tay-Sack's Disease.</label></li>
			<li><input type="radio" name="q5" id="q5_3" value="c" class="radio" tabindex="19" <?php if ($answer05 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'c'); } ?> /> 
			<label for="q5_3">Cystic Fibrosis.</label></li> 
			<li><input type="radio" name="q5" id="q5_4" value="d" class="radio" tabindex="20" <?php if ($answer05 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q5', 'd'); } ?> />
			<label for="q5_4">Huntington Disease.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>
	
	<dt><label for="single_select">36. It is believed that Alpha-1 affects as many as 100,000 individuals in the United States.</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q6" id="q6_1" value="a" class="radio" tabindex="21" <?php if ($answer06 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'a'); } ?> /> 
			<label for="q6_1">True.</label></li> 
			<li><input type="radio" name="q6" id="q6_2" value="b" class="radio" tabindex="22" <?php if ($answer06 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q6', 'b'); } ?> />
			<label for="q6_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">37. Panniculitis is a painful inflammatory skin disorder sometimes associated with Alpha-1 Antitrypsin Deficiency?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q7" id="q7_1" value="a" class="radio" tabindex="25" <?php if ($answer07 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'a'); } ?> /> 
			<label for="q7_1">True.</label></li> 
			<li><input type="radio" name="q7" id="q7_2" value="b" class="radio" tabindex="26" <?php if ($answer07 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q7', 'b'); } ?> />
			<label for="q7_2">False.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">38. Aspects of the treatment plan for individuals with Alpha-1 includes:</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q8" id="q8_1" value="a" class="radio" tabindex="29" <?php if ($answer08 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'a'); } ?> /> 
			<label for="q8_1">Smoking cessation and avoidance of environmental pollutants.</label></li> 
			<li><input type="radio" name="q8" id="q8_2" value="b" class="radio" tabindex="30" <?php if ($answer08 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'b'); } ?> />
			<label for="q8_2">Prompt treatment of respiratory infections, proper nutrition and exercise.</label></li>
			<li><input type="radio" name="q8" id="q8_3" value="c" class="radio" tabindex="31" <?php if ($answer08 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'c'); } ?> /> 
			<label for="q8_3">A and B.</label></li> 
			<li><input type="radio" name="q8" id="q8_4" value="d" class="radio" tabindex="32" <?php if ($answer08 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q8', 'd'); } ?> />
			<label for="q8_4">Annual gastroscopy.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">39. Resources in the community to assist those affected by Alpha-1 Antitrypsin Deficiency includes which of the following?</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q9" id="q9_1" value="a" class="radio" tabindex="33" <?php if ($answer09 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'a'); } ?> /> 
			<label for="q9_1">The Alpha-1 Foundation, The Alpha-1 Association.</label></li> 
			<li><input type="radio" name="q9" id="q9_2" value="b" class="radio" tabindex="34" <?php if ($answer09 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'b'); } ?> />
			<label for="q9_2">The American Lung Association.</label></li>
			<li><input type="radio" name="q9" id="q9_3" value="c" class="radio" tabindex="35" <?php if ($answer09 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'c'); } ?> /> 
			<label for="q9_3">AlphaNet.</label></li> 
			<li><input type="radio" name="q9" id="q9_4" value="d" class="radio" tabindex="36" <?php if ($answer09 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q9', 'd'); } ?> />
			<label for="q9_4">All of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dt><label for="single_select">40. It is important to establish IV access prior to mixing and pooling Prolastin-C because:</label></dt>
	<dd>
		<ul>
			<li><input type="radio" name="q10" id="q10_1" value="a" class="radio" tabindex="37" <?php if ($answer10 == "a") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'a'); } ?> /> 
			<label for="q10_1">It is good nursing practice when administering IV medications in the home.</label></li> 
			<li><input type="radio" name="q10" id="q10_2" value="b" class="radio" tabindex="38" <?php if ($answer10 == "b") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'b'); } ?> />
			<label for="q10_2">Prolastin-C is expensive and if IV access can not be established, the product may be inadvertently wasted.</label></li>
			<li><input type="radio" name="q10" id="q10_3" value="c" class="radio" tabindex="39" <?php if ($answer10 == "c") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'c'); } ?> />
			<label for="q10_3">Prolastin-C contains no preservative and must be infused within 3 hrs.</label></li>
			<li><input type="radio" name="q10" id="q10_4" value="d" class="radio" tabindex="40" <?php if ($answer10 == "d") { echo 'checked="checked"'; } else { echo $this->validation->set_radio('q10', 'd'); } ?> />
			<label for="q10_4">All of the above.</label></li>
		</ul>
	</dd>
	<dd class="clear"><hr /></dd>

	<dd class="submit"><input type="image" src="/public/shared/images//button-save.jpg" alt="Save Test" name="save_test" id="save_test" value="save_test" tabindex="42" /></dd>
	</dl>
</form>
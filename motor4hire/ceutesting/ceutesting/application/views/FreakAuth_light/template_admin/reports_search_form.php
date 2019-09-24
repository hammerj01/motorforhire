
<?php echo form_open('dashboard/reports/search/');?>

<dl class="two_column">
<dt><label for="name">Enter Last Name</label></dt>
<dd><input type="text" name="name" id="name" class="full" tabindex="1" value="<?php echo $this->validation->name; ?>" /> <input type="submit" value="Search" tabindex="2" /></dd>
<dd class="note">Tip: the first letter of the last name works too.</dd>
</dl>
</form>
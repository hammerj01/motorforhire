<?php  if (!defined('BASEPATH')) exit('No direct script access allowed');
/*
| -------------------------------------------------------------------------
| URI ROUTING
| -------------------------------------------------------------------------
| This file lets you re-map URI requests to specific controller functions.
|
| Typically there is a one-to-one relationship between a URL string
| and its corresponding controller class/method. The segments in a
| URL normally follow this pattern:
|
| 	www.your-site.com/class/method/id/
|
| In some instances, however, you may want to remap this relationship
| so that a different class/function is called than the one
| corresponding to the URL.
|
| Please see the user guide for complete details:
|
|	http://www.codeigniter.com/user_guide/general/routing.html
|
| -------------------------------------------------------------------------
| RESERVED ROUTES
| -------------------------------------------------------------------------
|
| There are two reserved routes:
|
|	$route['default_controller'] = 'welcome';
|
| This route indicates which controller class should be loaded if the
| URI contains no data. In the above example, the "welcome" class
| would be loaded.
|
|	$route['scaffolding_trigger'] = 'scaffolding';
|
| This route lets you set a "secret" word that will trigger the
| scaffolding feature for added security. Note: Scaffolding must be
| enabled in the controller in which you intend to use it.
|
*/

$route['default_controller'] = "home";
$route['scaffolding_trigger'] = "scaff";

//TEST PAGES
$route['dashboard'] = "admin/adminhome";
$route['dashboard/prolastin'] = "admin/prolastin";
$route['dashboard/prolastin/page_one'] = "admin/prolastin";
$route['dashboard/prolastin/page_one'] = "admin/prolastin";
$route['dashboard/prolastin/page_two'] = "admin/prolastin/page_two";
$route['dashboard/prolastin/page_three'] = "admin/prolastin/page_three";
$route['dashboard/prolastin/page_four'] = "admin/prolastin/page_four";
$route['dashboard/prolastin/score'] = "admin/prolastin/score";
$route['dashboard/prolastin/take_test_again'] = "admin/prolastin/take_test_again";

//SAVE TEST PAGES
$route['dashboard/prolastin/save/:num'] = "admin/prolastin/save";

//EVALUATION
$route['dashboard/evaluation'] = "admin/evaluation";
$route['dashboard/evaluation/view/:num'] = "admin/evaluation/view";

//CERTIFICATE
$route['dashboard/certificate/:num'] = "admin/certificate";
$route['dashboard/certificate'] = "admin/certificate";

//2017.08.16 jgray: added for new variable certificate
//EXTENDED CERTIFICATE
$route['dashboard/extendedcertificate/:num'] = "admin/extendedcertificate";
$route['dashboard/extendedcertificate'] = "admin/extendedcertificate";

//2017.08.16 jgray: added for new variable certificate
//PRINT CERTIFICATE
$route['dashboard/printcertificate/:num'] = "admin/printcertificate";
$route['dashboard/printcertificate'] = "admin/printcertificate";

//REPORTS
$route['dashboard/reports'] = "admin/reports/all";
$route['dashboard/reports/all'] = "admin/reports/all";
$route['dashboard/reports/all/:num'] = "admin/reports/all";
$route['dashboard/reports/search'] = "admin/reports/search";
$route['dashboard/reports/pass'] = "admin/reports/pass";
$route['dashboard/reports/pass/:num'] = "admin/reports/pass";
$route['dashboard/reports/fail'] = "admin/reports/fail";
$route['dashboard/reports/reports/:num'] = "admin/reports/all";
$route['dashboard/reports/progress'] = "admin/reports/progress";
$route['dashboard/reports/progress/:num'] = "admin/reports/progress";
$route['dashboard/reports/export/all'] = "admin/reports/exportall";
$route['dashboard/reports/export/all/:num'] = "admin/reports/exportall";

//PROFILE
$route['dashboard/profile'] = "admin/profile";
$route['dashboard/profile/:num'] = "admin/profile";

//USERS
$route['dashboard'] = "admin/adminhome";
$route['dashboard/users'] = "admin/users";
$route['dashboard/users/:num'] = "admin/users";
$route['dashboard/users/edit'] = "admin/users/edit";

//ADMINS
$route['dashboard/admins/add'] = "admin/admins/add";
$route['dashboard/admins/edit'] = "admin/admins/edit";
$route['dashboard/admins/edit/:num'] = "admin/admins/edit";
$route['dashboard/admins/show/:num'] = "admin/admins/show";
$route['dashboard/admins/del/:num'] = "admin/admins/del";
$route['dashboard/admins'] = "admin/admins";
$route['dashboard/admins/:num'] = "admin/admins";

//MY ACCOUNT
$route['dashboard/myaccount/show/:num'] = "myaccount/show";
$route['dashboard/myaccount/edit/:num'] = "myaccount/edit";

?>
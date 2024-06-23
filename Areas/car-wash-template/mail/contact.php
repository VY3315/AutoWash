<?php
if(empty($_POST['cname']) || empty($_POST['csubject']) || empty($_POST['cmessage']) || !filter_var($_POST['cemail'], FILTER_VALIDATE_EMAIL)) {
  http_response_code(500);
  exit();
}

$name = strip_tags(htmlspecialchars($_POST['cname']));
$email = strip_tags(htmlspecialchars($_POST['cemail']));
$m_subject = strip_tags(htmlspecialchars($_POST['csubject']));
$message = strip_tags(htmlspecialchars($_POST['cmessage']));

$to = "info@example.com"; // Change this email to your //
$subject = "$m_subject:  $name";
$body = "You have received a new message from your website contact form.\n\n"."Here are the details:\n\nName: $name\n\n\nEmail: $email\n\nSubject: $m_subject\n\nMessage: $message";
$header = "From: $email";
$header .= "Reply-To: $email";	

if(!mail($to, $subject, $body, $header))
  http_response_code(500);
?>

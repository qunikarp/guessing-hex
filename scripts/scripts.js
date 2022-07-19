const form = document.getElementById('form');
const username = document.getElementById('username');
const email = document.getElementById('email');
const password = document.getElementById('password');
const password2 = document.getElementById('password2');

// form.addEventListener('submit', e => {
// 	e.preventDefault();
	
// 	checkInputs();
// });
// nie wiem co to robi

function checkInputs() {
  const usernameValue = username.value.trim();
  const emailValue = email.value.trim();
  const passwordValue = password.value.trim();
  const password2Value = password2.value.trim();
}

  if(usernameValue === '') {
    setErrorFor(username, 'Username cannot be blank');
  }
  else {
    setSuccessFor(username);
  }
  if(emailValue === '') {
    setErrorFor(email, 'Email cannot be blank');
  }
  else if(!isEmail(emailValue)) {
    setErrorFor(email, 'Email is not valid');
  }
  else {
    setSuccessFor(email);
  }
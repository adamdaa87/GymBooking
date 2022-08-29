let createAjax = document.querySelector("#createajax");
document.querySelector('#fetch').addEventListener('click', fetchCreateForm);

function removeForm() {
    createAjax.innerHTML = "";
}

function failCreate(response) {
    console.log(response, 'failed to create');
    createAjax.innerHTML = response.responseText;

}

function fixValidation() {
    const form = createAjax.querySelector('form')
    $.validator.unobtrusive.parse(form) 
}

function fetchCreateForm() {
    fetch('https://localhost:7118/gymclasses/fetchForm', {
        method: 'GET',
        headers: {

        }
    })
        .then(res => res.text())
        .then(data => {
            createAjax.innerHTML = data;
            fixValidation();
        })
        .catch(err => console.log(err));
}


// Selecionar os elementos do formulário e campos de entrada
const form = document.querySelector("#form");
const inputUsuario = document.querySelector("#Usuario");
const inputSenha = document.querySelector("#SenhaOriginal");

window.onload = function () {
    // caso tenha dado algum erro de login
    if ($("#msgValidacao").val()) {
        $('#mensagem-validacao').show();
    }
};

// Função para exibir mensagens de erro nos campos de entrada
function inputError(input, mensagem) {
    let textError = input.nextElementSibling; 
    input.classList.add("border-danger"); 
    textError.innerHTML = mensagem; 
}

// Função para limpar mensagens de erro nos campos de entrada
function clearError(input) {
    let textError = input.nextElementSibling; 
    input.classList.remove("border-danger");
    textError.innerHTML = ""; 
}

// Evento de envio do formulário
form.addEventListener('submit', function(event) {
    clearError(inputUsuario);
    clearError(inputSenha);

    if (inputUsuario.value === "") {
        inputError(inputUsuario, "Preencha o campo de nome de usuário.");
        inputUsuario.focus();

        event.preventDefault();
    }

    if (inputSenha.value === "") {
        inputError(inputSenha, "Preencha o campo de senha");

        event.preventDefault();
    }
});








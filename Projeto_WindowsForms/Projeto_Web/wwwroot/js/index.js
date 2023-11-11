// Selecionar os elementos do formulário e campos de entrada
const form = document.querySelector("#form");
const inputUsuario = document.querySelector("#usuario");
const inputSenha = document.querySelector("#senha");

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
    event.preventDefault(); // Impede o envio padrão do formulário

    clearError(inputUsuario);
    clearError(inputSenha);

    if (inputUsuario.value === "") {
        inputError(inputUsuario, "Preencha o campo de nome de usuário.");
        inputUsuario.focus();
    } else if (inputUsuario.value !== "admin" && inputUsuario.value !== "user") {
        inputError(inputUsuario, "Usuário não encontrado.");
    }

    if (inputSenha.value === "") {
        inputError(inputSenha, "Preencha o campo de senha");
    } else if (inputSenha.value.length < 8) {
        inputError(inputSenha, "A senha deve ter pelo menos 8 caracteres");
    } else if (inputSenha.value !== "adminsistema" && inputSenha.value !== "usersistema") {
        inputError(inputSenha, "Senha incorreta. Digite novamente");
    }

    if (inputUsuario.value === "admin" && inputSenha.value === "adminsistema") {
        window.location.href = "pages/menuAdm.html";
    }

    if (inputUsuario.value === "user" && inputSenha.value === "usersistema") {
        window.location.href = "pages/menu.html";
    }
});








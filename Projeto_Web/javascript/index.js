// Seleciona os elementos do formulário e campos de entrada
const loginForm = document.querySelector("#login-form");
const usuarioInput = document.querySelector("#usuario");
const passwordInput = document.querySelector("#password");

// Função para exibir mensagem de erro em campos de entrada
function inputError(input, message) {
    let textError = input.nextElementSibling;

    input.style.border = "1px solid red";
    textError.style.display = "block";
    textError.innerHTML = message;
}

// Função para limpar mensagens de erro em campos de entrada
function clearError(input) {
    let textError = input.nextElementSibling;

    input.style.border = "1px solid #ccc";
    textError.style.display = "none";
    textError.innerHTML = "";
}

// Adiciona um ouvinte de evento ao formulário para validação do login
loginForm.addEventListener("submit", (event) => {
    event.preventDefault(); // Impede o envio do formulário padrão

    clearError(usuarioInput); // Limpa qualquer mensagem de erro anterior
    clearError(passwordInput);

    if (usuarioInput.value === "") {
        inputError(usuarioInput, "Por favor, preencha o campo de nome de usuário.");
        usuarioInput.focus();
    } else if (usuarioInput.value !== "admin") {
        inputError(usuarioInput, "Usuário não encontrado.");
    }

    if (passwordInput.value === "") {
        inputError(passwordInput, "Por favor, preencha o campo de senha");
    } else if (passwordInput.value.length < 4) {
        inputError(passwordInput, "A senha deve ter pelo menos 4 caracteres");
    } else if (passwordInput.value !== "admin") {
        inputError(passwordInput, "Senha incorreta. Digite novamente");
    }

    if (usuarioInput.value === "admin" && passwordInput.value === "admin") {
        // Redireciona para a página do menu em caso de login bem-sucedido
        window.location.href = "pages/menu.html"
    }
});






// Selecionar elementos do DOM
const inputFiltro = document.querySelector("#inputFiltro");
const btnFiltrar = document.querySelector("#btnFiltrar");
const tabelaRelatorios = document.querySelector("#tabelaRelatorios");
const formFiltro = document.querySelector("#form");

// Focar no campo de filtro ao carregar a página
inputFiltro.focus();

// Adicionar um ouvinte de evento de clique no botão de filtro
btnFiltrar.addEventListener('click', () => {
    filtrarTabela();
});

// Adicionar um ouvinte de evento de pressionar tecla no campo de filtro
inputFiltro.addEventListener('keyup', (event) => {
    event.preventDefault();

    if (event.key === 'Enter') {
        filtrarTabela();
    }
});

// Impedir o envio do formulário padrão
formFiltro.addEventListener('submit', (event) => {
    event.preventDefault();
});

// Função para filtrar a tabela com base no texto inserido no campo de filtro
function filtrarTabela() {
    let expressao = inputFiltro.value.toLowerCase();
    let linhas = tabelaRelatorios.getElementsByTagName("tr");

    for (let posicao in linhas) {
        if (true === isNaN(posicao)) {
            continue;
        }

        let conteudoDaLinha = linhas[posicao].innerHTML.toLowerCase();

        if (true === conteudoDaLinha.includes(expressao)) {
            linhas[posicao].style.display = ""; 
        } else {
            linhas[posicao].style.display = "none";
        }
    }

    inputFiltro.focus(); // Focar novamente no campo de filtro após a filtragem
}


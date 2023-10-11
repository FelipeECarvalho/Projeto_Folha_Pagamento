// Seleciona os elementos HTML relevantes
const inputFiltro = document.querySelector("#inputFiltro");
const tabelaRelatorios = document.querySelector("#tabela-relatorios");
const btnFiltrar = document.querySelector(".iconPesquisar");

// Define o foco inicial no campo de filtro
inputFiltro.focus();

// Adiciona um ouvinte de evento ao botão de filtragem
btnFiltrar.addEventListener('click', () => {
    filtrarTabela();
});

// Adiciona um ouvinte de evento à entrada do teclado no campo de filtro
inputFiltro.addEventListener('keyup', (event) => {
    if (event.key === 'Enter') {
        filtrarTabela();
    }
});

// Função para filtrar a tabela com base no valor do campo de filtro
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

    // Define o foco de volta no campo de filtro após a filtragem
    inputFiltro.focus();
}


//gerar pdf

/*const btnPdf = document.querySelector(".iconPdf");

btnPdf.addEventListener("click", () => {

    const options = {
        margin: [10, 10, 10, 10],
        filename: "relatorio.pdf",
        html2canvas: { scale: 2 },
        jsPDF: { unit: "mm", format: "a4", orientation: "portrait" }
    }

    html2pdf().set(options).from(document.getElementById("tabela-relatorios")).save();

})
*/


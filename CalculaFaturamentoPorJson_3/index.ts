import dados from "./src/dados_faturamento.json";

//Filtrando os dias que estao com valores zerados
let dadosEmOrdemAsc = dados.filter(item => item.valor != 0)
//Aplicando lista em ordem crescente
dadosEmOrdemAsc.sort((a, b) => a.valor - b.valor);

//Total itens
let totalItensLista = dadosEmOrdemAsc.length;
let menorValorFat = dadosEmOrdemAsc[0];
let maiorValorFat = dadosEmOrdemAsc[totalItensLista - 1];

let valorTotalFat = 0;
dadosEmOrdemAsc.forEach((item) => {
  valorTotalFat += item.valor;
});

let diasAcimaDaMedia = 0;
let mediaMensal = valorTotalFat / totalItensLista;
dadosEmOrdemAsc.forEach((item) => {
  if (item.valor > mediaMensal) {
    diasAcimaDaMedia += 1;
  }
});
console.info(`
    -> Maior faturamento 
    Dia ${maiorValorFat.dia} - Faturamento ${maiorValorFat.valor}
    -> Menor faturamento 
    Dia ${menorValorFat.dia} - Faturamento ${menorValorFat.valor}
    -> Média Mensal ${mediaMensal}
    -> Total de dias que superaram média ${diasAcimaDaMedia}
`);


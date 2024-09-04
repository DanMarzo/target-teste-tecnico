"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
var dados_faturamento_json_1 = __importDefault(require("./src/dados_faturamento.json"));
//Filtrando os dias que estao com valores zerados
var dadosEmOrdemAsc = dados_faturamento_json_1.default.filter(function (item) { return item.valor != 0; });
//Aplicando lista em ordem crescente
dadosEmOrdemAsc.sort(function (a, b) { return a.valor - b.valor; });
//Total itens
var totalItensLista = dadosEmOrdemAsc.length;
var menorValorFat = dadosEmOrdemAsc[0];
var maiorValorFat = dadosEmOrdemAsc[totalItensLista - 1];
var valorTotalFat = 0;
dadosEmOrdemAsc.forEach(function (item) {
    valorTotalFat += item.valor;
});
var diasAcimaDaMedia = 0;
var mediaMensal = valorTotalFat / totalItensLista;
dadosEmOrdemAsc.forEach(function (item) {
    if (item.valor > mediaMensal) {
        diasAcimaDaMedia += 1;
    }
});
console.info("\n    -> Maior faturamento \n    Dia ".concat(maiorValorFat.dia, " - Faturamento ").concat(maiorValorFat.valor, "\n    -> Menor faturamento \n    Dia ").concat(menorValorFat.dia, " - Faturamento ").concat(menorValorFat.valor, "\n    -> M\u00E9dia Mensal ").concat(mediaMensal, "\n    -> Total de dias que superaram m\u00E9dia ").concat(diasAcimaDaMedia, "\n"));

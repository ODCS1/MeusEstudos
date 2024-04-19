﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosEmMarte
{
  public class HashLinear<Tipo> : ITabelaDeHash<Tipo>
    where Tipo : IRegistro<Tipo>
  {
    Tipo[] dados;
    int qtd_elementos;
    const int TAM_MAXIMO = 131;
    //int tamanho;
    

    public HashLinear()
    {
        //tamanho = TAM_MAXIMO;
        dados = new Tipo[TAM_MAXIMO];
    }


        public int Hash(string chave)
        {

            // ESSE LOOP É PARA ENCONTRAR O VALOR DE HASH PARA UMA CHAVE JÁ ARMAZENADA
            for (int i = 0; i < dados.Length; i++)
            {
                if (chave.Equals(dados[i].Chave)) { return i; }
            }

            // PARA CHAVES AINDA NÃO ARMAZENADAS
            long tot = 0;
            for (int i = 0; i < chave.Length; i++)
                tot += 37 * tot + (char)chave[i];

            tot = tot % dados.Length;
            if (tot < 0)
                tot += dados.Length;

            int primeiraPosicao = (int) tot;
            int posicaoAtual = primeiraPosicao;
            int contador = 0;


            // NESSE PONTO PARA INSERÇÃO DE UM NOVO ELEMENTO JÁ ESTÁ GARANTIDO QUE EXISTE UMA POSIÇÃO VAGA
            while ((dados[posicaoAtual] != null) && (posicaoAtual != primeiraPosicao || contador == 0))
            {
                posicaoAtual++;
                contador++;
            }

            return posicaoAtual;
        }


        public List<Tipo> Conteudo()
        {
            List<Tipo> aux = new List<Tipo>();
            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i] != null)
                {
                    aux.Add(dados[i]);
                }
            }
            return aux;
        }

        public bool Existe(Tipo item, out int onde)
    {
            //onde = -1;
            // for (int i = 0;i < tamanho; i++)
            //{
            //    if (dados[i].Equals(item))
            //        onde = i;
            //        return true;
            //}

            //return false;


            // OU

            onde = Hash(item.Chave);
            return dados[onde].Equals(item);
    }

        public void Inserir(Tipo item)
        {
            if (!EstaCheio())
            {
                int pos = Hash(item.Chave);
                while (true)
                {
                    if (dados[pos] == null)
                    {
                        dados[pos] = item;
                        qtd_elementos++;
                        break;
                    }
                    pos++;
                }
            }
        }

        public bool EstaCheio()
        {

            if (qtd_elementos == TAM_MAXIMO) { return true; }
            return false;
        }

        public bool Remover(Tipo item)
        {
            int onde = 0;
            if (!Existe(item, out onde))
                return false;

            dados[onde] = default(Tipo);
            return true;
        }
  }
}
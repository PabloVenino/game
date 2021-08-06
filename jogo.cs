using System;

public class Campeao{
    public int forca;
    public int vida;
    public int espada;
    public bool vivo;
    public string nome;
    public Campeao(string nomeHeroi){
        forca=100;
        vida=500;
        espada=250;
        if(vida<0){
            vivo=true;
        }
        nome=nomeHeroi;
    }
}

public class Monstro1{
    public int forca;
    public int vida;
    public bool vivo;
    public string nome;
    public Monstro1(string nomeMonstro){
        forca=250;
        vida=1000;
        if(vida<0){
            vivo=true;
        }
        nome=nomeMonstro;
    }
}

public class Fase1{
    public static void Main(){
        // Declaração do primeiro Monstro.
        Monstro1 primeiroMonstro=new Monstro1("Asmutu");
        
        // Boas vindas ao game.
        Console.WriteLine("Hey threre, Welcome to the game!");
        Console.WriteLine("Olá, bem vindo ao game!");
        selecioneIdioma:
        Console.WriteLine("Do you wanna play it in English or Portuguese?");
        Console.WriteLine("Você quer jogar o jogo em Inglês ou em Português?");
        Console.WriteLine("Type [En] to English, escreva [Pt] para Português.");
        string idioma="";
        idioma=Console.ReadLine();

        switch(idioma){
            case "portugues":
            case "português":
            case "Pt":
            case "pt":
            case "pT":
            case "PT":
                idioma="Pt";
                break;
            case "English":
            case "english":
            case "En":
            case "en":
            case "eN":
            case "EN":
                idioma="En";
                break;
        }

        if(idioma=!"Pt" && idioma=!"En"){
            Console.WriteLine("Error trying to choose an language. Try it again.");
            Console.WriteLine("Falha ao tentar selecionar o idioma. Tente novamente.");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            goto selecioneIdioma;
        }

        if(idioma=="Pt"){
            Console.WriteLine("Primeiramente, Digite o nome do seu Herói.");

            // Solicitação do nick.
            string nomeHeroi;
            nomeHeroi=Console.ReadLine();
            Campeao Personagem1=new Campeao(nomeHeroi);

            // Introdução da História
            Console.WriteLine("\nCerto {0}. Esse é um jogo simples, com apenas escolhas a serem feitas pelo teclado.\n\nEspero que você se divirta.",nomeHeroi);
            Console.WriteLine("\nVocê está na Primeira Fase!\nE está prestes a enfrentar o temido {0}.\n\nEle possui pontos fortes e fracos, descubra-os.",primeiroMonstro.nome);
            tentativaEscolha1:
            Console.WriteLine("\n{0} avança pela direita, em sua direção, com seus grandes punhos diretamente em movimento diagonal.",primeiroMonstro.nome);
            Console.Write("Num movimento rápido você: [q] Pula | [w] desvia para esquerda | [e] desvia para direita: ");

            char escolha1;
            escolha1=Convert.ToChar(Console.ReadLine());
            switch(escolha1){
                case 'q':
                case 'Q':
                    escolha1='q';
                    break;
                case 'w':
                case 'W':
                    escolha1='w';
                    break;
                case 'e':
                case 'E':
                    escolha1='e';
                    break;
            }
        }

        if(escolha1=='q'){
            Personagem1.vida=400;
            Console.WriteLine("Infelizmente o pulo não foi alto suficiente, você levou 100 de dano, ficando com {0} de vida.",Personagem1.vida);
        }else if(escolha1=='w'){
            Console.WriteLine("Por muito pouco você escapou dos punhos fortes de {0}.",primeiroMonstro.nome);
        }else if(escolha1=='e'){
            Personagem1.vida=250;
            Console.WriteLine("Que pena, você levou muito dano, mas ainda há esperança. Sua vida agora é: {0}",Personagem1.vida);
        }else{
            Console.WriteLine("Sua escolha foi inválida, por gentileza, tente novamente...");
            System.Threading.Thread.Sleep(5000);
            goto tentativaEscolha1;
        }
        tentativaEscolha2:
        if(Personagem1.vida==500){
            Console.Write("\nCerto, com seu minuscioso movimento para a esquerda, agora você pode: ");
            Console.Write("[q] Atacar a perna de {0} | [w] Atacar o braço de {0} | [e] Atacar a barriga de {0}: ",primeiroMonstro.nome);
            char escolha2='a';
            escolha2=Convert.ToChar(Console.ReadLine());
            switch(escolha2){
                case 'q':
                case 'Q':
                    escolha2='q';
                    break;
                case 'w':
                case 'W':
                    escolha2='w';
                    break;
                case 'e':
                case 'E':
                    escolha2='e';
                    break;
            }
            if(escolha2=='q'){
                Console.WriteLine("");
            }else if(escolha2=='w'){
                Console.WriteLine("");
            }else if(escolha2=='e'){
                Console.WriteLine("{0} ficou atordoado de dor, sua vida total era: {1}.",primeiroMonstro.vida);
                primeiroMonstro.vida=1000-450;
                Console.WriteLine("Com seu Ataque de 450 de dano, agora, {0} está com {1} de vida.\nContinue assim para mata-lo com Maestria.",primeiroMonstro.nome,primeiroMonstro.vida);
            }else{
            Console.WriteLine("Sua escolha foi inválida, por gentileza, tente novamente...");
                System.Threading.Thread.Sleep(5000);
                goto tentativaEscolha2;
            }
        }   
    }
}

public int Ataque1(){
    int dano=150;
    return dano;
}

public int Ataque2(){
    int dano=50;
    return dano;
}

public int Ataque3(){
    int dano=450;
    return dano;
}
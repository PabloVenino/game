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
        Monstro1 primeiroMonstro=new Monstro1("Poinl");
        
        // Boas vindas ao game.
        Console.WriteLine("Olá, bem vindo ao game!");
        Console.WriteLine("Primeiramente, Digite o nome do seu Herói.");

        // Solicitação do nick.
        string nomeHeroi;
        nomeHeroi=Console.ReadLine();
        Campeao Personagem1=new Campeao(nomeHeroi);

        Console.WriteLine("\nCerto {0}. Esse é um jogo simples, com apenas escolhas a serem feitas pelo teclado.\n\nEspero que você se divirta.",nomeHeroi);
        Console.WriteLine("\nVocê está na Primeira Fase!\nE está prestes a enfrentar o temido {0}.\n\nEle possui pontos fortes e fracos, descubra-os.",primeiroMonstro.nome);
        tentativa:
        Console.WriteLine("\n{0} avança pela direita, em sua direção, com seus grandes punhos diretamente em movimento diagonal.",primeiroMonstro.nome);
        Console.Write("Num movimento rápido você: [q] Pula | [w] desvia para esquerda | [e] desvia para direita: ");

        char escolha;
        escolha=Convert.ToChar(Console.ReadLine());
        switch(escolha){
            case 'q':
            case 'Q':
                escolha='q';
                break;
            case 'w':
            case 'W':
                escolha='w';
                break;
            case 'e':
            case 'E':
                escolha='e';
                break;
        }
        if(escolha=='q'){
            Personagem1.vida=400;
            Console.WriteLine("Infelizmente o pulo não foi alto suficiente, você levou 100 de dano, ficando com {0} de vida.",Personagem1.vida);
        }else if(escolha=='w'){
            Console.WriteLine("Por muito pouco você escapou dos punhos fortes de {0}.",primeiroMonstro.nome);
        }else if(escolha=='e'){
            Personagem1.vida=250;
            Console.WriteLine("Que pena, você levou muito dano, mas ainda há esperança. Sua vida agora é: {0}",Personagem1.vida);
        }else{
            Console.WriteLine("Sua escolha foi inválida, por gentileza, tente novamente...");
            Console.Clear();
            goto tentativa;
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
}
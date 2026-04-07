# 🎨 Gerador de Decágono - Computação Gráfica

Projeto desenvolvido em **C# (Windows Forms)** com o objetivo de aplicar conceitos fundamentais de **computação gráfica**, como:

* Sistemas de coordenadas
* Cálculo de distância
* Ângulos e trigonometria
* Geração de pontos aleatórios
* Primitivas gráficas

---

## 📌 Descrição

O programa permite ao usuário selecionar uma cor através de um **ComboBox** e, ao clicar no botão, desenha um **decágono preenchido com pontos aleatórios** na tela.

O desenho é realizado utilizando o evento `Paint`, respeitando o ciclo de renderização do Windows Forms.

---

## ⚙️ Funcionamento

1. O usuário seleciona uma cor no ComboBox
2. Clica no botão para desenhar
3. O programa:

   * Marca o estado (`bntapertado = true`)
   * Chama `Invalidate()` para solicitar repintura
4. O evento `Paint` é acionado
5. O decágono é desenhado com base em cálculos matemáticos

---

## 🧠 Conceitos Utilizados

### 🔹 Primitivas Gráficas

* `pintaP()` → desenha um ponto na tela
* `caneta()` → cria um objeto `Pen`
* `cores()` → cria cores usando RGB

### 🔹 Funções Matemáticas

* Cálculo de distância (`distance`)
* Cálculo de ângulo (`angulo`)
* Módulo adaptado (`Modulo`)
* Divisão angular (`seccao`)
* Distância máxima para formar o polígono (`distancemax`)

---

## 🔢 Lógica do Decágono

O decágono é gerado utilizando:

* Um conjunto de pontos aleatórios dentro de uma área quadrada
* Um filtro matemático que verifica se o ponto está dentro do polígono

```csharp
if (d < d_max)
{
    pintaP(...);
}
```

Esse cálculo garante que apenas os pontos internos ao decágono sejam desenhados.

---

## 🎨 Seleção de Cores

A cor é definida através do ComboBox e convertida para RGB pela função:

```csharp
corDoComboBox()
```

Exemplo:

* Vermelho → (255, 0, 0)
* Verde → (0, 255, 0)
* Azul → (0, 0, 255)

---

## 🖥️ Interface

A interface contém:

* ComboBox para seleção de cores
* Botão para gerar o desenho
* Área de renderização (Form)

---

## 🚀 Como Executar

1. Abrir o projeto no **Visual Studio**
2. Compilar (`Ctrl + Shift + B`)
3. Executar (`F5`)
4. Selecionar uma cor
5. Clicar no botão para desenhar

---

## ⚠️ Observações

* O desenho ocorre apenas quando o evento `Paint` é acionado
* O uso de `Invalidate()` garante a atualização da interface
* A variável `bntapertado` controla quando o desenho deve ser realizado

---

## 👨‍💻 Autores

Heitor Pinheiro de Souza
Mateus Todeschini Monteiro

---

## 📚 Objetivo Acadêmico

Este projeto tem como foco:

* Aplicação prática de conceitos matemáticos
* Entendimento do ciclo de renderização do Windows Forms
* Organização de código em primitivas gráficas

---

✨ Projeto simples, mas com fundamentos sólidos de computação gráfica.

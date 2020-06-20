# Perguntas teóricas de introdução

1. Em quais linguagens o C# foi inspirado?
A sintaxe foi fortemente inspirada nas linguagens C e C++, com alguns influências de Java, Delphi e Object Pascal.

2. Inicialmente o C# foi criado para qual finalidade?
A linguagem foi escrita para servir de ferramenta de desenvolvimento para o .Net Framework, uma iniciativa ambiciosa da Microsoft de ter o mesmo código rodando em diversos dispositivos. Algo muito próximo ao que fazem as JVM, ainda que estruturalmente elas sejam diferentes.

3. Quais os principais motivos para a Microsoft ter migrado para o Core?
As especificações das versões anteriores do framework tinham forte acoplamento com o Windows. As dependências de pacotes também estavam mal distribuídas. 
Com o .Net Core, houve uma melhor distribuição das dependências - principalmente as web - e principalmente o Framework tornou-se open source, rodando inclusive no Linux

4. Cite as principais diferenças entre .Net Full Framework e .Net Core.
A principal diferença é que o .net Core é uma solução open-source e multi-plataforma, tendo a Microsoft como mantenedora, este também é voltado para o desenvolvimento de soluções Web, com uma série de simplificações e otimizações. Já o .Net Full Framework possibilita o desenvolvimento voltado para desktop (Windows Forms, WPF e etc). O desenvolvimento web dispobilizado pelo .Net Full Framework possui algumas opções mais atreladas ao windows (WCF, por exemplo, integração com IIS e assim por diante), sendo menos portável.

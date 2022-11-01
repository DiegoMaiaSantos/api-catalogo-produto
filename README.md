# <h1 align="center">API Catalogo Produto</h1>

[![GitHub license](https://img.shields.io/github/license/DiegoMaiaSantos/api-catalogo-produto)](https://github.com/DiegoMaiaSantos/api-catalogo-produto/blob/main/LICENSE)

 <p>
 Esse projeto tem como principal objetivo, desenvolver meus conhecimentos adquiridos diariamente no estágio, então peguei uma ideia simples e utilizei grande parte da experiencia que tenho tido, para fixar melhor os estudos e as rotinas diárias de um programador. 
Inicialmente planejava utilizar a abordagem code first, usando migration do Entity framework para criar o banco de dados e suas tabelas, de maneira quase que automática, mas como queria ampliar o conhecimento na abordagem de mapeamentos com o banco sendo criado manualmente no SQL Server, fiz o banco CatalogoDB e suas tabelas, sendo CATEGORIA E PRODUTO, fiz o desenho do relacionamento das entidades (desenho está logo abaixo) e passo detalhes sobre informações de cada coluna, também criei a FOREIGN KEY (PK_PRODUTO_CATEGORIA) para trabalhar a troca de informações entre as tabelas. Caso tenha interesse em clonar a API, é necessário criar o mesmo banco na sua máquina, lembrando que a configuração é toda realizada para SQL Server.
Essa API (Application Programming Interface) serve como um intermediário de um software que vai permitir que dois aplicativos possam se comunicar. Eu fiz apenas o backend, mas se o caso fosse outro, onde tivesse desenvolvido a aplicação e a interface, front e back, essa API iria receber as requisições de uma interface e dentro de toda a aplicação, ela iria percorrer os controllers que iria buscar na services, as regras do negócio, praticamente é onde fica a maior parte da lógica e depois iria nos repository, que é onde acontece a troca de informações da aplicação com o banco de dados, e assim ela retorna fazendo o inverso do que foi caminhado até chegar novamente nas controllers e repassar a informação requisitada pela interface. No caso da minha API, é possível buscar uma lista, buscar pelo id, criar, atualizar ou deletar, seja uma categoria ou um produto, mais conhecido como um CRUD.
Usei o modelo de arquitetura DDD (Domain Driven Design) para manter a organização e manutenção dos processos da API. Esse modelo tem como característica facilitar a implementação de regras e processos complexos, onde trás a divisão das responsabilidades por camadas, e pode ser usado por qualquer tecnologia. (desenho está logo abaixo)
Foi implementado Health Checks para acompanhar a saúde da API, ele é um middleware que fornece um endpoint que vai nos trazer a situação da aplicação, é uma forma de dizer que a aplicação está saudável ou não para uma solicitação web. Em conjunto implementei o serilog, pois tinha planos de realizar acompanhamento de loggin da aplicação.
Realizei uma mesclagem entre as versões 5 e 6 do .Net para configurar as classes program.cs e startup.cs, assim me dando a oportunidade de trabalhar com mais camadas de segurança nas conexões do banco de dados. 
Para documentar a aplicação usei o framework Swagger, que oferece muitas ferramentas, ajuda na descrição, no consumo e na visualização dos serviços. Também pode ser usado com qualquer linguagem de programação.
Os commits e as Branchs foram feitos seguindo regras para manter uma boa organização e utilizando o Git Bash.
 </p>

 <p align="center">
<img src="http://img.shields.io/static/v1?label=STATUS&message=%20ANDAMENTO&color=YELLOW&style=for-the-badge"/>
</p>

## 🖨️ Como clonar o projeto: 
```
  # Clone o repositório
  git clone https://github.com/DiegoMaiaSantos/api-catalogo-produto.git
  ```
***

## 📷 Fluxograma da API: 
<p align ="center">
 <img src ="" width =""/>
 </p>

***
## 📷 Arquitetura do projeto: 
<p align ="center">
 <img src ="https://github.com/DiegoMaiaSantos/imagens-projetos-variados/blob/main/api-catalogo-produto-readme/arquitetura-ddd.jpg" width =""/>
 </p>

***
## 📷 Relacionamento de entidades: 
<p align ="center">
 <img src ="https://github.com/DiegoMaiaSantos/imagens-projetos-variados/blob/main/api-catalogo-produto-readme/ApiCatalogo_Diagrama.png?raw=true" width =""/>
 </p>

***
## 📷 Imagens do projeto: 
<p align ="center">
 <img src ="https://github.com/DiegoMaiaSantos/imagens-projetos-variados/blob/main/api-catalogo-produto-readme/swagger-apicatalogo-01.png" width =""/>
 </p>
 
 <p align ="center">
 <img src ="https://github.com/DiegoMaiaSantos/imagens-projetos-variados/blob/main/api-catalogo-produto-readme/swagger-apicatalogo-02.png" width =""/>
 </p>   

***
## ☑️ Tecnologias e Ferramentas: 
* [.Net 6.0](https://learn.microsoft.com/pt-br/dotnet/core/whats-new/dotnet-6)
* [Swagger](https://swagger.io/)
* [Entity Framework](https://learn.microsoft.com/pt-br/ef/)
* [SQL Server Managent](https://learn.microsoft.com/pt-br/sql/ssms/sql-server-management-studio-ssms?view=sql-server-ver16)
* [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)
* [Git Bash](https://git-scm.com/doc)
***
## 💻 Autor:
_Diego Maia Santos_ 
<div> 
  <a href = "mailto:diegom.santos03@gmail.com"><img src="https://img.shields.io/badge/-Gmail-%23333?style=for-the-badge&logo=gmail&logoColor=white" target="_blank"></a>
  <a href="https://br.linkedin.com/in/diego-maia-santos-21615b208" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a> 
</div>

***
## ⚠️ Licença:
Esse projeto está sob a [licença MIT](https://github.com/DiegoMaiaSantos/api-catalogo-produto/blob/main/LICENSE).

***

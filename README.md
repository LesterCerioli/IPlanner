# IPlanner

Documentação de Projeto- LP


1-	Objetivos:

=> A aplicação tem como objetivo permitir o cadastro de usuários, inclusão de documentos, realizados pelo Life Planner.
=> Observar-se-à que o aplicativo deverá permitir as operações básicas de cadastro e inclusão de documentação em modo offline caso não    haja conectividade de Internet no momento de cadastro.
=> A aplicação deverá consumir bases de dados existentes

O NET Core possui funcionalidades de Local Storage que funciona como um storage temporário de dados, quando a incluysão de dados é feita em ambiente offline e mediante implementação de “observador de conexão”- observable connection , assim que o operador estiver em contato com uma conexão de internet, os dados serão transferidos para uma base.

2-	Arquitetura

Implementar arquitetura orientada à serviços com objetivo de proporcionar isolanilidade entre os diversos módulos;

Implementação da abordagem REST FULL pois assim poderá futuramente permitir que diversos devices móveis possam conectar ao aplicativo ou até mesmo consumer API’s implementadas.

Recomenda-se implementar uma arquitetura orientada a domínios com portabilidade para serviços e adaptável ao REST FULL ,uma vez, que o ”Super APP” possui uma arquitetura moldada e com presença de REST. O motivo e justificativa de se utilizar Rest Full se dá pelo motivo, caso necessário
De implementar Web API’s diferentes de acordo com o desenvolvimento dos módulos.

Implementação de Endpoint que funcionará como HUB entre o LP e o Super App.

Caso ocorra a necessidade de implementar um banco de dados isolado, este poderá possuir as tabelas necessárias e por meio de stored procedures, pode-se criar estratégias de “PUT” das tabelas para o banco de dados existente. Isto permite que não precise conectar diretamente ao banco e mesmo no DB do LP, usar-se-à validações de acordo com as regras de negócio, proporcionado maior Segurança e alta performance.

Recomenda-se a implementação de auditoria para controle de alteração do Código Sql das tabelas, que se fará necessário devido a necessidade de manutenção da aplicação e proporciona
um gerenciamento muito mais acertivo.

3-      Controle de Versionamento


  Recomenda-se o uso da metodologia de versionamento Git Flow por apresentar as seguintes vantagens:
  
-	Criação de banches relacionadas à task pertinente de determinada Sprint, sendo assim permitindo realizar o rastreamento d      commit,       elaboração de gráficos gerenciais que auxiliam muito em tomadas de decisões.
	
-	Implementação de code reviews a fim de realizar testes por desenvolvedores diferentes da equipe, caso isto for possível ocorrer













4-	Pipeline

       SDK:
	*NET Core 3.0
	*NET Core 3.1
       Observação importante: recomenda-se o NET Core 3.1 pois ele oferece grande suporte para        tecnologias front-end bem como extensões, caso seja necessário.
       Obs2: o NET Core  é um SDK multiplataforma que permite o desenvolvimento de software portável para diversas plataformas, incluindo , Windows, Linux e MacOS, não havendo necessário adaptações adicionais para compilação.


Obs3: caso haja necessidade futura de migração de versão do NET Core para a “latest version”, não haverá problemas de compilação, já que o NET Core permite upgrade sem quebra de pacotes.





Project Documentation - LP 

1- Objectives: 

=> The application aims to allow the registration of users, inclusion of documents, carried out by Life Planner. 
=> It will be noted that the application must allow basic operations of registration and inclusion of documentation in offline mode if    there is no Internet connectivity at the time of registration. 
=> The application must consume existing data bases 

   NET Core has Local Storage functionality that works as a temporary data storage, when data is included in an offline environment and through the implementation of “connection observer” - observable connection, once the operator is in contact with a connection Internet, data will be transferred to a database.  

2- Architecture 

Implement service-oriented architecture in order to provide isolation between the various modules; Implementation of the REST FULL approach so that in the future it will be able to allow several mobile devices to connect to the application or even consumer API’s implemented.

It is recommended to implement an architecture oriented to domains with portability for services and adaptable to REST FULL, since the "Super APP" has a molded architecture and with the presence of REST. The reason and justification for using Rest Full is given by the reason, if necessary To implement different Web API’s according to the development of the modules. 

Endpoint implementation that will function as a HUB between the LP and the Super App. 

If there is a need to implement an isolated database, it may have the necessary tables and through stored procedures, it is possible to create “PUT” strategies for the tables for the existing database. This allows you to not need to connect directly to the bank and even in the LP DB, validations will be used according to business rules, providing greater security and high performance. 

It is recommended to implement an audit to control the alteration of the Sql Code of the tables, which will be necessary due to the need to maintain the application and provides much more accurate management.

3- Versioning Control   

It is recommended to use the Git Flow versioning methodology as it has the following advantages:    

- Creation of banches related to the relevant task of a given Sprint, thus allowing to carry out the tracking of commit, elaboration of management graphics that help a lot in decision making. 

- Implementation of code reviews in order to carry out tests by developers other than the team, if this is possible.












4- Pipeline

       SDK:
* NET Core 3.0
* NET Core 3.1
       Important note: NET Core 3.1 is recommended as it offers great support for front-end technologies as well as extensions, if necessary.
       Obs2: NET Core is a multiplatform SDK that allows the development of portable software for several platforms, including Windows, Linux and MacOS, with no additional adaptations necessary for compilation.


Obs3: in case there is a future need to migrate from NET Core version to the “latest version”, there will be no compilation problems, since NET Core allows an upgrade without breaking packages.



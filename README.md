# IPlanner

Documentação de Projeto- LP


1-	Objetivos:

=> A aplicação tem como objetivo permitir o cadastro de usuários, inclusão de documentos, realizados pelo Life Planner.
=> Observar-se-à que o aplicativo deverá permitir as operações básicas de cadastro e inclusão de documentação em modo offline caso não    haja conectividade de Internet no momento de cadastro.
=> A aplicação deverá consumir bases de daedos existentes

O NET Core possui funcionalidades de Local Storage que funciona como um storage temporário de dados, quando a incluysão de dados é feita em ambiente offline e mediante implementação de “observador de conexão”- observable connection , assim que o operador estiver em contato com uma conexão de internet, os dados serão transferidos para uma base.

2-	Arquitetura

Implementar arquitetura orientada à serviços com objetivo de proporcionar isolanilidade entre os diversos módulos;

Implementação da abordagem REST FULL pois assim poderá futuramente permitir que diversos devices móveis possam conectar ao aplicativo ou até mesmo consumer API’s implementadas.

Recomenda-se implementar uma arquitetura orientada a domínios com portabilidade para serviços e adaptável ao REST FULL ,uma vez, que o”Super APP” possui uma arquitetura moldada e com presença de REST. O motive e justificativa de se utilizer Rest Full se dá pelo motive, caso necessário
De implementar Web API’s diferentes de acordo com o desenvolvimento dos módulos.

Implementação de Endpoint que funcionará como HUB entre o LP e o Super App.

Caso ocorra a necessidade de implementar um banco de dados isolado, este poderá possuir as tabelas necessárias e por meio de stored procedures, pode-se criar estratégias de “PUT” das tabelas para o banco de dados existente. Isto permite que não precise conectar diretamente ao banco e mesmo no DB do LP, usar-se-à validações de acordo com as regras de negócio, proporcionado maior Segurança e alta performance.

Recomenda-se a implementação de auditoria para controle de alteração do Código Sql das tabelas, que se fará necessário devido a necessidade de manutenção da aplicação e proporciona
um gerenciamento muito mais acertivo.


3-	Controle de Versionamento

  Recomenda-se o uso da metodologia de versionamento Git Flow por apresentar as seguintes vantagens:
  
-	Criação de banches relacionadas à task pertinente de determinada Sprint, sendo assim permitindo realizar o rastreamento d commit,       elaboração de gráficos gerenciais que auxiliam muito em tomadas de decisões.
	
-	Implementação de code reviews a fim de realizar testes por desenvolvedores diferentes da equipe, caso isto for possível ocorrer













4-	Pipeline

       SDK:
	*NET Core 3.0
	*NET Core 3.1
       Observação importante: recomenda-se o NET Core 3.1 pois ele oferece grande suporte para        tecnologias front-end bem como extensões, caso seja necessário.
       Obs2: o NET Core  é um SDK multiplataforma que permite o desenvolvimento de software portável para diversas plataformas, incluindo , Windows, Linux e MacOS, não havendo necessário adaptações adicionais para compilação.


Obs3: caso haja necessidade futura de migração de versão do NET Core para a “latest version”, não haverá problemas de compilação, já que o NET Core permite upgrade sem quebra de pacotes.

_Repositório apenas para estudo_

# Post: Criando um API Gateway com ASP.NET Core e Ocelot

Conheça o conceito de API Gateway e veja como criá-lo em uma aplicação ASP.NET utilizando a biblioteca Ocelot.

Instrutor:

- [Wladimilson M. Nascimento](https://www.treinaweb.com.br/blog/autor/wladimilson-m-nascimento)

Referências:

- https://www.treinaweb.com.br/blog/criando-um-api-gateway-com-asp-net-core-e-ocelot

<br>
<br>

## Conteúdo

Atualmente fala-se muito na criação de microsserviços, aplicações que executam uma função específica. Quando se cria um sistema baseado nesta arquitetura, teremos vários microsserviços executando funcionalidades específicas do sistema.

Como demostrado na imagem abaixo:

![Microservice Architecture](https://github.com/jeanbarcellos/estudo.csharp.api-gateway-ocelot/raw/master/docs/imgs/01.png)

Assim, pode ocorrer situações onde é necessário obter informações de mais de um microsserviço, ou o sistema precisa ser consumido por vários clients. Com aplicações mobile, web, aplicações de terceiro, etc.

Nestes cenários, pode ser custoso ter que gerenciar o acesso de cada microsserviço do sistema. Cada um com as suas particularidades. É neste ponto que entra o API Gateway.

### **API Gateway**

O API Gateway funciona como uma porta de entrada para o clients dos microsserviços do sistema. No lugar de chamar os microsserviços diretamente, os clients chamam a API Gateway, que redireciona a solicitação para o microsserviço apropriado. Quando o microsserviço retornar à solicitação, o API Gateway a retorna para o client.

Ou seja, ele funciona como uma camada intermediária entre os clients e os microsserviços. Como todas as solicitações irão passar por ele, o gateway pode modificar as solicitações recebidas e retornadas, o que nos fornece algumas vantagens:

- Os microsserviços podem ser modificados sem se preocupar com os clients;
- Os microsserviços podem se comunicar utilizando qualquer tipo de protocolo. O importante é o gateway implementar um protocolo que seja compreendido pelos clients;
- O gateway pode implementar recursos que não impactam nos microsserviços, como autenticação, logging, SSL, balanceamento de carga, etc.
- A imagem abaixo ilustra bem o funcionamento do API Gateway:

![Funcionamento do API Gateway](https://docs.microsoft.com/en-us/azure/architecture/guide/architecture-styles/images/microservices-logical.svg)

### **Ocelot**

Ocelot é uma biblioteca que permite criar um API Gateway com o ASP.NET. Possuindo uma grande gama de funcionalidades, como:

- Agregação de solicitações;
- Roteamento;
- Autenticação;
- Cache;
- Balanceamento de carga;
- Log;
- WebSockets;
- Service Fabric.

Mesmo que seja voltado para aplicações .NET que estejam implementando uma arquitetura de microsserviços, o Ocelot pode ser utilizado como API Gateway de qualquer tipo de sistema que implemente esta arquitetura.

# Extensions Methods

Os métodos de extensão posssibilitam a criação de funcionalidades de um tipo de dado sem ter que cria um novo tipo herdado desse tipo de dado. Desta forma está nova funcionalidade
passa a ser tratado como um membro existente daquele tipo, assim você pode chamar este método como um método de instância de um tipo já existente.

Por exemplo, podemos criar uma nova funcionalidade para o tipo int, sem a necessidade de herdar de sua respectiva classe, criando um novo método que pode ser chamado como um método de 
instância de int.

Podemos fazer o mesmo com uma classe, para evitar que a mesma seja modificada.

Essa implementação possibilita a aplicação do pricícpio aberto/fechado (SOLID), onde um classe está fechada para modificação e aberta para extensão, ou seja, adicionamos um nova 
funcionalidade na classe, mas mantemos como está a já existente.


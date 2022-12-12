# Extensions Methods

Os m�todos de extens�o posssibilitam a cria��o de funcionalidades de um tipo de dado sem ter que cria um novo tipo herdado desse tipo de dado. Desta forma est� nova funcionalidade
passa a ser tratado como um membro existente daquele tipo, assim voc� pode chamar este m�todo como um m�todo de inst�ncia de um tipo j� existente.

Por exemplo, podemos criar uma nova funcionalidade para o tipo int, sem a necessidade de herdar de sua respectiva classe, criando um novo m�todo que pode ser chamado como um m�todo de 
inst�ncia de int.

Podemos fazer o mesmo com uma classe, para evitar que a mesma seja modificada.

Essa implementa��o possibilita a aplica��o do pric�cpio aberto/fechado (SOLID), onde um classe est� fechada para modifica��o e aberta para extens�o, ou seja, adicionamos um nova 
funcionalidade na classe, mas mantemos como est� a j� existente.


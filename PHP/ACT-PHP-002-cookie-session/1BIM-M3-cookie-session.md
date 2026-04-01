## Exercício 1 - Diferença entre cookies e sessions

Cookies são arquivos de texto que são armazenados no navegador do usúario, para que o servidor se lembre das informações do usúario, como temas, login e idioma.   Por serem armazenados no navegador do usúario, os cookies são mais vulneráveis a ataques como *Croos-Site* ou *Scripting*(XSS).

Sessions oferecem mais segurança ao armazenar os dados do usúario no servidor. Ao acessar o site o servidor cria uma nova sessão e armazena os dados associados desta sessão, e então o servidor cria um cookie contendo o ID da sessão e envia ao navegador do usúario, assim, ao logar novamente no site o navegador envia o cookie com o ID da sessão de volta ao servidor, para que o servidor recupere os dados associados ao usúario.

Comumente os cookies são preferíveis para armazenar informações como idioma, temas, layout etc. Ou seja, dados leves, não sensíveis e para serem armazenados a longo prazo. Enquanto sessions são melhores para dados temporários que são necessário durante a navegação no site, como carrinhos de compra, dados de login etc. Ou dados sensíveis que necessitam de estarem seguros como dados pessoais.

## Exercício 2 — Como cookies e sessions poderiam ser utilizados

Em uma loja virtual, cookies e sessions se complementam conforme a sensibilidade e a necessidade de persistência de cada dado.

Para manter o usuário logado, os dados sensíveis ficam no servidor via session, e apenas o session_id é salvo em um cookie com HttpOnly e Secure, evitando exposição e ataques XSS. Para o carrinho, visitantes usam cookie local para evitar fricção com cadastro, enquanto usuários logados usam session, que é mais segura e acessível em qualquer dispositivo — com migração automática dos itens ao fazer login. Para preferências de tema, idioma e moeda, o cookie persistente é o ideal, já que esses dados não são sensíveis e precisam estar disponíveis mesmo antes do login, algo que a session não garante por expirar ao fechar o navegador.

A regra geral é: dados sensíveis vão para a session no servidor, dados não sensíveis que precisam persistir vão para cookies. Pela LGPD, cookies de autenticação e carrinho são estritamente necessários, mas os de preferências exigem consentimento do usuário.

## Exercício 3 — Pergunta de investigação

– O que aconteceu em cada etapa?

1. Na primeira execução, a página exibe a mensagem: "Cookie ainda não disponível" no canto da tela. O cookie ainda não aparece porque ele acabou de ser enviado e ainda não foi retornado pelo navegador.
2. Após atualizar a página, exibe-se a mensagem: "Valor do cookie: 1" no canto da tela. O cookie passa a ser exibido porque o navegador já o enviou ao servidor.
3. Ao acessar as ferramentas do navegador, é possível visualizar o cookie armazenado.
4. Ao limpar os cookies e atualizar novamente, o valor deixa de aparecer, pois o cookie foi removido.

– Por que o cookie não aparece imediatamente na primeira execução?

O cookie não aparece imediatamente porque, primeiro, o servidor (PHP) envia o cookie; em seguida, o navegador o recebe e o armazena. Somente na próxima requisição o navegador devolve o cookie ao servidor.

## Exercício 4 - Por que sessions são geralmente preferidas para autenticação de usuários

Sessions são mais comuns para autenticação de usuários principalmente pela segurança, pois ao utilizar cookies, os dados são armazenados no navegador, assim podendo ser manipulados pelo usúario, além de vírus e etc. Ao alocar os dados em sessions no servidor, evita qualquer manipulação do usúario, ou vírus, além de ao usar sessions além dos cookies, protege dados confindenciais e etc. Pois ao usar apenas cookies todos os dados ficam acessíveis ao usúario.



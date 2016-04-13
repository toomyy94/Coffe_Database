--index

drop index nameCli on cafe.Cliente
create index nameCli on cafe.Cliente(nomeCli)
select nomeCli, NIF
from cafe.Cliente
order by nomeCli


drop index nameFor on cafe.Fornecedor	
create index nameFor on cafe.Fornecedor(nomeForn)
select nomeForn, CC_Forn
from cafe.Fornecedor
order by nomeForn asc


drop index nameFunc on cafe.Funcionario	
create index nameFunc on cafe.Funcionario(nomeFunc)
select nomeFunc, CCFunc
from cafe.Funcionario
order by nomeFunc asc	


create index nameProd on cafe.Produto(nomeProd)	


create index nameReclama on cafe.Reclamacao(motivo)

		
-- indice para procurar os funcionarios com determinado turno
create index TurnoFuncionarios on cafe.Funcionario(turnoFunc)
select nomeFunc, CCFunc, turnoFunc
from cafe.Funcionario
where turnoFunc != 'noite'




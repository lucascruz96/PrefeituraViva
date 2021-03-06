CREATE TABLE Tipo (
  idTipo INT  NOT NULL   AUTO_INCREMENT,
  Descricao VARCHAR(100)  NULL    ,
PRIMARY KEY(idTipo));



CREATE TABLE Usuario (
  Id_usuario INT  NOT NULL   AUTO_INCREMENT,
  Nome VARCHAR(100)  NULL  ,
  Senha VARCHAR(16)  NULL  ,
  Sexo CHAR  NULL  ,
  Idade INT  NULL  ,
  CPF VARCHAR(14)  NULL  ,
  Email VARCHAR(100)  NULL    ,
PRIMARY KEY(Id_usuario));



CREATE TABLE Votacao (
  Id_Vota INT  NOT NULL   AUTO_INCREMENT,
  Assunto VARCHAR(100)  NULL  ,
  Texto TEXT  NULL    ,
PRIMARY KEY(Id_Vota));



CREATE TABLE Reuniao (
  Id_Reuniao INT  NOT NULL   AUTO_INCREMENT,
  Endereco VARCHAR(100)  NULL  ,
  Tema VARCHAR(100)  NULL  ,
  Texto TEXT  NULL  ,
  Ativo VARCHAR(3)  NULL  ,
  Horario TIMESTAMP  NULL    ,
PRIMARY KEY(Id_Reuniao));



CREATE TABLE Assunto (
  idAssunto INTEGER UNSIGNED  NOT NULL   AUTO_INCREMENT,
  DescricaoAssun VARCHAR(100)  NULL    ,
PRIMARY KEY(idAssunto));



CREATE TABLE Voto (
  Usuario_Id_usuario INT  NOT NULL  ,
  Votacao_Id_Vota INT  NOT NULL    ,
PRIMARY KEY(Usuario_Id_usuario, Votacao_Id_Vota)  ,
INDEX Usuario_has_Votacao_FKIndex1(Usuario_Id_usuario)  ,
INDEX Usuario_has_Votacao_FKIndex2(Votacao_Id_Vota),
  FOREIGN KEY(Usuario_Id_usuario)
    REFERENCES Usuario(Id_usuario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Votacao_Id_Vota)
    REFERENCES Votacao(Id_Vota)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);



CREATE TABLE Presenca (
  Usuario_Id_usuario INT  NOT NULL  ,
  Reuniao_Id_Reuniao INT  NOT NULL    ,
PRIMARY KEY(Usuario_Id_usuario, Reuniao_Id_Reuniao)  ,
INDEX CadrastroUsu_has_Reuniao_FKIndex1(Usuario_Id_usuario)  ,
INDEX CadrastroUsu_has_Reuniao_FKIndex2(Reuniao_Id_Reuniao),
  FOREIGN KEY(Usuario_Id_usuario)
    REFERENCES Usuario(Id_usuario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Reuniao_Id_Reuniao)
    REFERENCES Reuniao(Id_Reuniao)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);



CREATE TABLE Informacao (
  idInformacao INTEGER UNSIGNED  NOT NULL   AUTO_INCREMENT,
  Usuario_Id_usuario INT  NOT NULL  ,
  Assunto_idAssunto INTEGER UNSIGNED  NOT NULL  ,
  Tipo_idTipo INT  NOT NULL  ,
  Titulo VARCHAR(50)  NULL  ,
  Conteudo TEXT  NULL    ,
PRIMARY KEY(idInformacao)  ,
INDEX Informacao2_FKIndex1(Tipo_idTipo)  ,
INDEX Informacao2_FKIndex2(Assunto_idAssunto)  ,
INDEX Informacao2_FKIndex3(Usuario_Id_usuario),
  FOREIGN KEY(Tipo_idTipo)
    REFERENCES Tipo(idTipo)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Assunto_idAssunto)
    REFERENCES Assunto(idAssunto)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Usuario_Id_usuario)
    REFERENCES Usuario(Id_usuario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);
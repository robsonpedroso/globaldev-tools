# Global Dev Tools

Pacote de ferramentas para ajudar no desenvolvimento de projetos

## Introdução

Essas instruções fornecerão uma cópia do projeto em execução na sua máquina local para fins de desenvolvimento e teste.
Consulte implantação para obter notas sobre como implantar o projeto em um sistema ativo.

### Prerequisitos

O que você precisa para baixar, rodar e disponibilizar.

* Um editor de sua preferência
* Dotnet core 3.1 instalado

### Instalação

Após a execução do pre requisitos, segue um passo a passo de como rodar localmente.

Clonar o repositório

```
git clone git@github.com:robsonpedroso/globaldev-tools.git
```

Acesse a pasta do projeto que foi clonado e execute o build

```
dotnet build
```

## Diretórios

1. `docs` - Contém o arquivo Readme.md e caso necessário outras documentações para suporte a execução e manutenção.
2. `src` - Projeto com o código fonte das ferramentas

### Padrão de Tecnologia utilizado

## Execução dos testes

Não foi gerado

## Publicação

Não esquecer de publicar o xml do projeto para o swagger funcionar corretamente

## Versionamento

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

```
Given a version number MAJOR.MINOR.PATCH, increment the:

MAJOR version when you make incompatible API changes,
MINOR version when you add functionality in a backwards compatible manner, and
PATCH version when you make backwards compatible bug fixes.
Additional labels for pre-release and build metadata are available as extensions to the MAJOR.MINOR.PATCH format.
```

## Autores

* **Robson Pedroso** - *Projeto inicial* - [RobsonPedroso](https://github.com/robsonpedroso)

## License

[MIT](https://opensource.org/licenses/MIT)


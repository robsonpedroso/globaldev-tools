# Global Dev Tools

Pacote de ferramentas para ajudar no desenvolvimento de projetos

## Utilização

Segue algumas informações de como utilizar

[Extensão de Strings](https://github.com/robsonpedroso/globaldev-tools/blob/main/docs/string_extensions.md)

[Extensão de Enum](https://github.com/robsonpedroso/globaldev-tools/blob/main/docs/enum_extensions.md)

[Extensão de Guid](https://github.com/robsonpedroso/globaldev-tools/blob/main/docs/guid_extensions.md)

[Extensão de List](https://github.com/robsonpedroso/globaldev-tools/blob/main/docs/list_extensions.md)

[Extensão de Objetos genéricos](https://github.com/robsonpedroso/globaldev-tools/blob/main/docs/objects_extensions.md)

[Extensão de DateTime](https://github.com/robsonpedroso/globaldev-tools/blob/main/docs/datetime_extensions.md)

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


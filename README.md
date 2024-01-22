# DesafioArquitetura

Testando o projeto via Postman:

{
  "openapi": "3.0.1",
  "info": {
    "title": "DesafioArquitetura.API",
    "version": "1.0"
  },
  "paths": {
    "/api/Cliente": {
      "get": {
        "tags": [
          "Cliente"
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "post": {
        "tags": [
          "Cliente"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "put": {
        "tags": [
          "Cliente"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Cliente/{id}": {
      "get": {
        "tags": [
          "Cliente"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "style": "simple",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "delete": {
        "tags": [
          "Cliente"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "style": "simple",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/ClienteLancamento": {
      "get": {
        "tags": [
          "ClienteLancamento"
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "post": {
        "tags": [
          "ClienteLancamento"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteLancamentoDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteLancamentoDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteLancamentoDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "put": {
        "tags": [
          "ClienteLancamento"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteLancamentoDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteLancamentoDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/ClienteLancamentoDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/ClienteLancamento/{id}": {
      "get": {
        "tags": [
          "ClienteLancamento"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "style": "simple",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "delete": {
        "tags": [
          "ClienteLancamento"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "style": "simple",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Lancamento": {
      "get": {
        "tags": [
          "Lancamento"
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "post": {
        "tags": [
          "Lancamento"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/LancamentoDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/LancamentoDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/LancamentoDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "put": {
        "tags": [
          "Lancamento"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/LancamentoDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/LancamentoDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/LancamentoDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Lancamento/{id}": {
      "get": {
        "tags": [
          "Lancamento"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "style": "simple",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "delete": {
        "tags": [
          "Lancamento"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "style": "simple",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "ClienteDto": {
        "required": [
          "cpf",
          "nomeCompleto"
        ],
        "type": "object",
        "properties": {
          "id": {
            "type": "string",
            "format": "uuid"
          },
          "nomeCompleto": {
            "minLength": 1,
            "type": "string"
          },
          "cpf": {
            "minLength": 1,
            "type": "string"
          }
        },
        "additionalProperties": false
      },
      "ClienteLancamentoDto": {
        "required": [
          "clienteId",
          "dataLancamento",
          "lanlamentoId",
          "tipoLancamento",
          "valor"
        ],
        "type": "object",
        "properties": {
          "id": {
            "type": "string",
            "format": "uuid"
          },
          "clienteId": {
            "type": "string",
            "format": "uuid"
          },
          "lanlamentoId": {
            "type": "string",
            "format": "uuid"
          },
          "dataLancamento": {
            "type": "string",
            "format": "date-time"
          },
          "tipoLancamento": {
            "$ref": "#/components/schemas/TipoLancamento"
          },
          "valor": {
            "type": "number",
            "format": "double"
          },
          "descricao": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "LancamentoDto": {
        "required": [
          "descricao"
        ],
        "type": "object",
        "properties": {
          "id": {
            "type": "string",
            "format": "uuid"
          },
          "descricao": {
            "minLength": 1,
            "type": "string"
          }
        },
        "additionalProperties": false
      },
      "TipoLancamento": {
        "enum": [
          0,
          1
        ],
        "type": "integer",
        "format": "int32"
      }
    }
  }
}

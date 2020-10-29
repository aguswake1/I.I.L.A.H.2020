
from flask import Flask, render_template, redirect

app = Flask(__name__)


@app.route('/')
def raiz():
    return redirect("http://127.0.0.1:5000/message=*Ingrese su mensaje*")


@app.route('/message=<mensaje>')
def msg(mensaje):  # La función recibe como parámetro el parámetro que se envia en la URL
    if (mensaje != "*Ingrese su mensaje*"):
        with open("texto.txt", 'a') as file:  # Con el texto abierto se hace un append
            file.write(mensaje + '\n')
            file.close()
    archivo = open("texto.txt", 'r')
    return render_template('index.html', mensaje=open("texto.txt").read())


if __name__ == "__main__":
    app.run()

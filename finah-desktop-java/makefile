default: net/azurewebsites/finahweb/main.class
	java  -cp "json.jar:." net.azurewebsites.finahweb.main
net/azurewebsites/finahweb/API.class: net/azurewebsites/finahweb/API.java net/azurewebsites/finahweb/Vraag.class net/azurewebsites/finahweb/Rapport.class net/azurewebsites/finahweb/Antwoord.class
	javac -cp "json.jar:." net/azurewebsites/finahweb/API.java
net/azurewebsites/finahweb/Vraag.class: net/azurewebsites/finahweb/Vraag.java net/azurewebsites/finahweb/Debug.class
	javac -cp "json.jar:." net/azurewebsites/finahweb/Vraag.java
net/azurewebsites/finahweb/main.class: net/azurewebsites/finahweb/main.java net/azurewebsites/finahweb/API.class net/azurewebsites/finahweb/Debug.class
	javac -cp "json.jar:." net/azurewebsites/finahweb/main.java
net/azurewebsites/finahweb/Rapport.class: net/azurewebsites/finahweb/Rapport.java net/azurewebsites/finahweb/Debug.class
	javac -cp "json.jar:." net/azurewebsites/finahweb/Rapport.java
net/azurewebsites/finahweb/Antwoord.class: net/azurewebsites/finahweb/Antwoord.java net/azurewebsites/finahweb/Debug.class
	javac -cp "json.jar:." net/azurewebsites/finahweb/Antwoord.java
net/azurewebsites/finahweb/Debug.class: net/azurewebsites/finahweb/Debug.java
	javac -cp "json.jar:." net/azurewebsites/finahweb/Debug.java

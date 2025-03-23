package MultiMethods

import (
	"encoding/json"
	"fmt"
	"io"
	"log"
	"net/http"
	"strconv"

	"github.com/gorilla/mux"
)

type model struct {
	ID          int    `json:"id"`
	Name        string `json:"name"`
	Description string `json:"description"`
}

type all []model

var List = all{
	{
		ID:          1,
		Name:        "Martillo",
		Description: "Cabeza de acero, con agarradera de madera",
	},
}

func HandlerTools(w http.ResponseWriter, r *http.Request) {
	log.Printf("toolsHandler ejecutado: %s", r.Method)

	vars := mux.Vars(r)
	id, idExists := vars["id"]
	switch r.Method {
	case "GET":
		if idExists {
			getById(w, id)
		} else {
			get(w, r)
		}

	case "POST":
		if idExists {
			w.WriteHeader(http.StatusMethodNotAllowed)
			fmt.Fprint(w, "No se puede usar un ID en la creación de una herramienta")
		} else {
			create(w, r)
		}

	case "DELETE":
		if idExists {
			delete(w, id)
		} else {
			w.WriteHeader(http.StatusBadRequest)
			fmt.Fprint(w, "Se debe especificar un ID para eliminar una herramienta")
		}

	default:
		w.WriteHeader(http.StatusMethodNotAllowed)
		fmt.Fprintf(w, "Método no permitido")
	}
}

func getById(w http.ResponseWriter, id string) {
	log.Println("GET /tools/{id} ejecutado")
	Id, err := strconv.Atoi(id)
	if err != nil {
		w.WriteHeader(http.StatusBadRequest)
		fmt.Fprintf(w, "ID inválido: %v", err)
		return
	}

	for _, t := range List {
		if t.ID == Id {
			w.Header().Set("Content-Type", "application/json")
			json.NewEncoder(w).Encode(t)
			return
		}
	}

	w.WriteHeader(http.StatusNotFound)
	fmt.Fprintf(w, "Herramienta no encontrada")
}

func get(w http.ResponseWriter, _ *http.Request) {
	log.Println("GET /tools ejecutado")
	w.Header().Set("Content-Type", "application/json")
	json.NewEncoder(w).Encode(List)
}

func create(w http.ResponseWriter, r *http.Request) {
	log.Println("POST /tools ejecutado")
	var new model

	reqBody, err := io.ReadAll(r.Body)
	if err != nil {
		w.WriteHeader(http.StatusBadRequest)
		fmt.Fprintf(w, "Error con los datos enviados: %v", err)
		return
	}

	err = json.Unmarshal(reqBody, &new)
	if err != nil {
		w.WriteHeader(http.StatusBadRequest)
		fmt.Fprintf(w, "Error al procesar los datos: %v", err)
		return
	}

	new.ID = len(List) + 1
	List = append(List, new)

	w.Header().Set("Content-Type", "application/json")
	w.WriteHeader(http.StatusCreated)
	json.NewEncoder(w).Encode(new)
}

func delete(w http.ResponseWriter, id string) {
	log.Println("DELETE /tools ejecutado")
	ID, err := strconv.Atoi(id)
	if err != nil {
		w.WriteHeader(http.StatusBadRequest)
		fmt.Fprintf(w, "ID inválido: %v", err)
		return
	}

	for idx, t := range List {
		if t.ID == ID {
			List = append(List[:idx], List[idx+1:]...)
			w.WriteHeader(http.StatusNoContent)
			return
		}
	}

	w.WriteHeader(http.StatusNotFound)
	fmt.Fprintf(w, "Herramienta no encontrada")
}

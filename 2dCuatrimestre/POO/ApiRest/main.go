package main

import (
	"fmt"
	"log"
	"net/http"

	"./MultiMethods"

	"github.com/gorilla/mux"
)

func indexRoute(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "Welcome to my API")
}

func main() {
	router := mux.NewRouter().StrictSlash(true)

	router.HandleFunc("/", indexRoute)
	router.HandleFunc("/tools", MultiMethods.HandlerTools).Methods("GET", "POST")
	router.HandleFunc("/tools/{id}", MultiMethods.HandlerTools).Methods("GET", "PUT", "DELETE")

	log.Fatal(http.ListenAndServe(":3000", router))
}

#!/bin/bash

# Caminho real do .desktop que chamou o script
DESKTOP_FILE="$(realpath "$0")"

# Pasta onde o .desktop está
DIR="$(dirname "$DESKTOP_FILE")"

# Abre o VS Code nessa pasta
codium "$DIR"

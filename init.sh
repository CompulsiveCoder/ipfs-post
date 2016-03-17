DIR=$PWD

echo "Initializing ipfs-post project"
echo "Dir: $PWD"

cd mod/ipfs-echo/
INIT_FILE="init.sh"
if [ ! -f "$INIT_FILE" ]; then
  echo "ipfs-echo init file not found: $PWD/$INIT_FILE. Did the submodule fail to initialize?"
else
  echo "ipfs-echo submodule found"
  sh init.sh
  cd $DIR

  cd lib
  sh get-libs.sh
  cd $DIR
fi

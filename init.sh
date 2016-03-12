DIR=$PWD

cd lib
sh get-libs.sh
cd $DIR

cd mod/ipfs-echo/
sh init.sh
cd $DIR

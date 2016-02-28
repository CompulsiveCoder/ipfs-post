DIR=$PWD

cd mod/ipfs-echo/
sh build.sh
cd $DIR

xbuild src/ipfs.post.sln /p:Configuration=Release

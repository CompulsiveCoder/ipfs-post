DIR=src/ipfs.post.WWW/ipfs-data


if [ ! -d "$DIR" ];
then
    mkdir $DIR
fi

cd $DIR
/usr/local/bin/ipfs init -f
/usr/local/bin/ipfs daemon

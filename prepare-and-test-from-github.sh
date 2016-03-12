BRANCH=$1

if [ -z "$BRANCH" ]; then
    BRANCH="master"
fi

curl https://raw.githubusercontent.com/CompulsiveCoder/ipfs-post/$BRANCH/prepare.sh | sh
curl https://raw.githubusercontent.com/CompulsiveCoder/ipfs-post/$BRANCH/test-from-github.sh | sh -s $BRANCH

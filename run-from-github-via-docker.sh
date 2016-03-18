BRANCH=$1

if [ -z "$BRANCH" ]; then
    BRANCH=$(git branch | sed -n -e 's/^\* \(.*\)/\1/p')
fi

if [ -z "$BRANCH" ]; then
    BRANCH="master"
fi

echo "Branch: $BRANCH"

docker run -i -p 8081:8081 compulsivecoder/ubuntu-mono-ipfs /bin/bash -c "curl https://raw.githubusercontent.com/CompulsiveCoder/ipfs-post/$BRANCH/run-from-github.sh | sh -s $BRANCH"

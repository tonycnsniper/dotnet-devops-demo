import { useEffect, useState } from "react";
import EventCard from "../../components/EventCard";
import getThreaters from "../../apis/threater";
import { Threater } from "../../types/threater";

export default function MoveList() {
  const [threaters, setThreaters] = useState<Threater[]>();

  useEffect(() => {
    const fetchData = async () => {
      const data = await getThreaters();
      if (data.length > 0) {
        setThreaters(data);
      }
    };
    fetchData();
  }, []);

  return (
    <ul className="relative overflow-hidden mb-8">
      {threaters &&
        threaters.map((threater) => (
          <EventCard key={threater.id} {...threater} />
        ))}
    </ul>
  );
}
